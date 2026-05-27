using System.IO;
using DevExpress.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using NLog;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Data.Enum;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Empleado;
using Sistema.Proctor.WinForm.Views.Proyecto.Reportes;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Humedad
{
    public partial class HumedadControl : XtraUserControl
    {
        private EnsayoHumedadDto _ensayoHumedad;
        private MuestraDto? _muestraDto;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private int _EnsayadoPor;
        private int _RevisadoPor;
        private int _AutorizadoPor;
        private int _VerificadoPor;

        public HumedadControl(EnsayoHumedadDto ensayoHumedad)
        {
            InitializeComponent();
            _ensayoHumedad = ensayoHumedad;
            ensayoHumedadDtoBindingSource.DataSource = _ensayoHumedad;
            dxErrorProvider1.DataSource = ensayoHumedadDtoBindingSource;
            dxErrorProvider1.ContainerControl = this;
            LoadMuestra();
        }

        private async void LoadMuestra()
        {
            try
            {
                var enumeradores = new Enumeradores();
                cmbMetodo.Properties.Items.AddRange(enumeradores.MetodoUtilizadoHumedad);
                if (_ensayoHumedad.Idensayohumedad <= 0)
                {
                    cmbMetodo.SelectedIndex = 0;
                }
                else
                {
                    using IUnitOfWork unitOfWork = new UnitOfWork();
                    var resultadoHumedadRepository = unitOfWork.ResultadoEnsayoHumedadRepository;
                    var resultados = await resultadoHumedadRepository.GetByCriteriaAsync(humedad =>
                        humedad.Idensayohumedad == _ensayoHumedad.Idensayohumedad);
                    resultadoHumedadBindingSource.DataSource = resultados;
                }

                _muestraDto = await DependenciasGlobalesForm.Instance.GetMuestraDto();
                if (_muestraDto is null)
                {
                    XtraMessageBox.Show("No se ha cargado la muestra para este ensayo", "Muestra", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (_ensayoHumedad.Idensayohumedad > 0)
                {
                    _EnsayadoPor = _ensayoHumedad.EnsayadoPor ?? 0;
                    _RevisadoPor = _ensayoHumedad.RevisadoPor ?? 0;
                    _AutorizadoPor = _ensayoHumedad.AutorizadoPor ?? 0;
                    _VerificadoPor = _ensayoHumedad.VerificadoPor ?? 0;
                }
                else
                {
                    _EnsayadoPor = 0;
                    _RevisadoPor = 0;
                    _AutorizadoPor = 0;
                    _VerificadoPor = 0;
                }

                txtMuestra.Text = _muestraDto.MuestraNumero;
                txtLado.Text = _muestraDto.LadoBanda;
                txtUbicacionMuestreo.Text = _muestraDto.SondeoNumero;
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al recuperar la muestra en HumedadControl");
            }
        }

        private void gridViewHumedad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (XtraMessageBox.Show("¿Eliminar registro?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                var view = sender as GridView;
                if (view is null)
                {
                    return;
                }

                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridViewHumedad_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (sender is not GridView view) return;

            try
            {
                // Solo recalcular si se modifica alguna de las columnas involucradas
                if (e.Column == colPesoSecoTara || e.Column == colPesoTara || e.Column == colPesoHumedoTara)
                {
                    if (!TryGetDecimal(view, e.RowHandle, colPesoTara, out var pesoTara) ||
                        !TryGetDecimal(view, e.RowHandle, colPesoHumedoTara, out var pesoHumedoTara) ||
                        !TryGetDecimal(view, e.RowHandle, colPesoSecoTara, out var pesoSecoTara))
                    {
                        return;
                    }

                    // Validar los datos antes de calcular
                    if (pesoSecoTara <= 0 || pesoTara >= pesoSecoTara)
                    {
                        XtraMessageBox.Show("Los valores ingresados no son válidos. Verifique los datos.");
                        return;
                    }

                    // Calcular el peso del agua y la humedad
                    var pesoAgua = pesoHumedoTara - pesoSecoTara;
                    var pesoSecoSinTara = pesoSecoTara - pesoTara;

                    if (pesoSecoSinTara <= 0)
                    {
                        XtraMessageBox.Show("El peso seco sin tara no puede ser cero o negativo.");
                        return;
                    }

                    var humedad = (pesoAgua / pesoSecoSinTara) * 100m;

                    // Asignar valores validados a las celdas
                    view.SetRowCellValue(e.RowHandle, colHumedad, Math.Max(humedad, 0).ToString("F2"));
                    view.SetRowCellValue(e.RowHandle, colPesoAgua, Math.Max(pesoAgua, 0).ToString("F2"));
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show($"Error en el cálculo: {exception.Message}");
            }
        }

        // Método auxiliar para intentar obtener un valor decimal validado
        private bool TryGetDecimal(GridView view, int rowHandle, GridColumn column, out decimal value)
        {
            value = 0m;
            var cellValue = view.GetRowCellValue(rowHandle, column)?.ToString();
            return !string.IsNullOrEmpty(cellValue) && decimal.TryParse(cellValue, out value);
        }

        private void gridViewHumedad_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (sender is not GridView view) return;

            decimal profundidadInicial = 0m;
            decimal profundidadFinal = 0.5m;

            // Verificar si hay filas previas para tomar la profundidad final de la última fila
            if (view.RowCount > 0)
            {
                var ultimaFilaHandle = view.GetRowHandle(view.RowCount - 1);
                if (TryGetDecimal(view, ultimaFilaHandle, colProfundidadFinal, out var ultimaProfundidadFinal))
                {
                    profundidadInicial = ultimaProfundidadFinal;
                    profundidadFinal = profundidadInicial + 0.5m;
                }
            }

            // Asignar los valores automáticamente a la nueva fila
            view.SetRowCellValue(e.RowHandle, colProfundidadInicial, profundidadInicial);
            view.SetRowCellValue(e.RowHandle, colProfundidadFinal, profundidadFinal);
        }

        private void gridViewHumedad_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (sender is not GridView view) return;

            // Validar que las columnas de profundidad no estén vacías
            if (!TryGetDecimal(view, e.RowHandle, colProfundidadInicial, out var profundidadInicial) ||
                !TryGetDecimal(view, e.RowHandle, colProfundidadFinal, out var profundidadFinal))
            {
                e.Valid = false;
                e.ErrorText = "Las profundidades no pueden estar vacías.";
                return;
            }

            if (!TryGetDecimal(view, e.RowHandle, colHumedad, out var humedad))
            {
                e.Valid = false;
                e.ErrorText = "La humedad no puede estar vacia.";
                return;
            }

            // Validar que la profundidad final sea mayor a la inicial
            if (profundidadFinal <= profundidadInicial)
            {
                e.Valid = false;
                e.ErrorText = "La profundidad final debe ser mayor a la inicial.";
            }

            if (decimal.Compare(humedad, decimal.Zero) == 0)
            {
                e.Valid = false;
                e.ErrorText = "La humedad no puede ser cero";
            }
        }

        private void gridViewHumedad_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction; // Evitar mensaje de error predeterminado
            gridViewHumedad.CancelUpdateCurrentRow(); // Cancelar la adición de la fila
        }

        public async Task Save()
        {
            try
            {
                /*
                 * Autorizado por
                 * Ensayado por: quien realizó el ensayo
                 * Revisado por: el usuario que ingresa los datos
                 * Verificado por
                 */
                if (_EnsayadoPor <= 0)
                {
                    XtraMessageBox.Show("Debe especificar quién realizó el ensayo", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dxErrorProvider1.HasErrors)
                {
                    XtraMessageBox.Show("Complete todos los campos para guardar los datos", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var resultadosGrid = (IList<ResultadoHumedad>)resultadoHumedadBindingSource.List;
                var rowCount = resultadosGrid.Count;
                if (rowCount <= 0)
                {
                    XtraMessageBox.Show("No hay registro de humedad a guardar", "Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                splashScreenManager1.ShowWaitForm();
                using IUnitOfWork unitOfWork = new UnitOfWork();
                var parametros = await unitOfWork.Parametros();
                if (parametros is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    await XtraMessageBox.ShowAsync("No hay configuración de parametros en el sistema");
                    return;
                }

                if (parametros.AutorizadoPor is 0 && _AutorizadoPor == 0)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show(
                        "No hay parametro para ingresar sobre: Autorizado por, verifique los parametros o ingrese el Autorizado",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (parametros.VerificadoPor is 0 && _VerificadoPor == 0)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show(
                        "No hay parametro para ingresar sobre: Verificado por, verifique los parametros o ingrese el Verificado",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var usuario = DependenciasGlobalesForm.Instance.Usuario;
                var ensayoHumedadRepository = unitOfWork.EnsayoHumedadRepository;
                var resultadoHumedadRepository = unitOfWork.ResultadoEnsayoHumedadRepository;
                var tipoEnsayoRepository = unitOfWork.TipoEnsayoRepository;
                var ensayoRepository = unitOfWork.EnsayosRepository;

                var tipoEnsayo = await tipoEnsayoRepository.GetFirstByCriteriaAsync(tipoEnsayo => tipoEnsayo.Descripcion == "Humedad");
                if (tipoEnsayo is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show(
                        "No existe el parametro del tipo de ensayo Proctor en la base de datos, genere el parametro de tipo de ensayo para continuar",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_muestraDto is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("No hay muestra disponible en la base de datos con el codigo suministrado",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ensayosByMuestra = await ensayoRepository.GetEnsayosByMuestra(_muestraDto.Idmuestra);
                var ensayoRecordDto =
                    ensayosByMuestra.FirstOrDefault(dto => dto.IdTipoEnsayo == tipoEnsayo.Idtipoensayo);

                if (ensayoRecordDto is null)
                {
                    var ensayo = new Ensayo
                    {
                        EdadReal = 0,
                        FechaIngreso = DateTime.Now,
                        FechaPrevista = DateTime.Now,
                        FechaReal = DateTime.Now,
                        Idempleado = _muestraDto.Idempleado,
                        Idtipoensayo = tipoEnsayo.Idtipoensayo,
                        Idmuestra = _muestraDto.Idmuestra,
                    };
                    await ensayoRepository.AddAsync(ensayo);
                }

                var ensayoHumedad = _ensayoHumedad.GetEnsayoHumedad();
                ensayoHumedad.Idmuestra = _muestraDto.Idmuestra;
                ensayoHumedad.RevisadoPor = usuario.Idusuario;
                ensayoHumedad.AutorizadoPor =
                    parametros.AutorizadoPor is > 0 ? parametros.AutorizadoPor.Value : _AutorizadoPor;
                ensayoHumedad.VerificadoPor = parametros.VerificadoPor is > 0
                    ? parametros.VerificadoPor.Value
                    : _VerificadoPor;
                ensayoHumedad.EnsayadoPor = _EnsayadoPor;
                if (ensayoHumedad.Idensayohumedad == 0)
                {
                    ensayoHumedad.CreatedBy = usuario.Idusuario;
                    ensayoHumedad.UpdatedBy = usuario.Idusuario;
                    await ensayoHumedadRepository.AddAsync(ensayoHumedad);
                }
                else
                {
                    ensayoHumedad.UpdateAt = DateTime.Now;
                    ensayoHumedad.UpdatedBy = usuario.Idusuario;
                    ensayoHumedadRepository.Update(ensayoHumedad);
                }

                // ✅ Guarda el ensayo antes de insertar los resultados
                await unitOfWork.PreviewSaveChanges();


                await resultadoHumedadRepository.DeleteWhereIdNotIn(ensayoHumedad.Idensayohumedad, resultadosGrid);

                for (var i = 0; i < rowCount; i++)
                {
                    var resultado = resultadosGrid[i];
                    resultado.Consecutivo = i + 1;
                    if (resultado.Idresultadohumedad == 0)
                    {
                        resultado.CreatedBy = usuario.Idusuario;
                        resultado.UpdatedBy = usuario.Idusuario;
                        resultado.Idensayohumedad = ensayoHumedad.Idensayohumedad;
                        await resultadoHumedadRepository.AddAsync(resultado);
                    }
                    else
                    {
                        resultado.UpdateAt = DateTime.Now;
                        resultado.UpdatedBy = usuario.Idusuario;
                        resultadoHumedadRepository.Update(resultado);
                    }
                }

                await unitOfWork.CompleteAsync();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show($"No fue posible guardar los resultados, {e.Message}", "Guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(e, "Error al guardar el ensayo de humedad");
            }
            finally
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
        }

        public async void Print()
        {
            try
            {
                using IUnitOfWork unitOfWork = new UnitOfWork();
                var resultadoHumedadRepository = unitOfWork.ResultadoEnsayoHumedadRepository;
                var reprote = new ReporteResultadoEnsayoHumedad();
                var resultados =
                    await resultadoHumedadRepository.GetResultadosEnsayoHumedad(_ensayoHumedad.Idensayohumedad);
                reprote.DataSource = resultados;
                var sucursal = DependenciasGlobalesForm.Instance.SelectedSucursal;
                //if (sucursal.Logo.Length > 0)
                //{
                //    reprote.xrPictureBox1.ImageSource = null;
                //    using var memory = new MemoryStream(sucursal.Logo);
                //    reprote.xrPictureBox1.ImageSource = new ImageSource(DXImage.FromStream(memory));
                //}

                //reprote.lblDireccionSucursal.Text = sucursal.Direccion;
                //reprote.lblNombreSucursal.Text = sucursal.NombreComercial;
                //reprote.lblEmailSucursal.Text = sucursal.Email;
                //reprote.lblRepresentante.Text = sucursal.Representante;
                var designTool = new ReportPrintTool(reprote);
                designTool.PreviewRibbonForm.Text = "Reporte de Humedad";
                designTool.ShowRibbonPreview();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Error(e);
            }
        }

        private void btnEnsayadoPor_Click(object sender, EventArgs e)
        {
            var selectEmpleado = new SelectEmpleadoDialog();
            if (selectEmpleado.ShowDialog() != DialogResult.OK) return;
            var empleado = selectEmpleado.EmpleadoSeleccionado;
            if (empleado is null)
            {
                return;
            }

            _EnsayadoPor = empleado.Idempleado;
        }

        private void btnAutorizadoPor_Click(object sender, EventArgs e)
        {
            var selectEmpleado = new SelectEmpleadoDialog();
            if (selectEmpleado.ShowDialog() != DialogResult.OK) return;
            var empleado = selectEmpleado.EmpleadoSeleccionado;
            if (empleado is null)
            {
                return;
            }

            _AutorizadoPor = empleado.Idempleado;
        }

        private void btnVerificadoPor_Click(object sender, EventArgs e)
        {
            var selectEmpleado = new SelectEmpleadoDialog();
            if (selectEmpleado.ShowDialog() != DialogResult.OK) return;
            var empleado = selectEmpleado.EmpleadoSeleccionado;
            if (empleado is null)
            {
                return;
            }

            _VerificadoPor = empleado.Idempleado;
        }
    }
}