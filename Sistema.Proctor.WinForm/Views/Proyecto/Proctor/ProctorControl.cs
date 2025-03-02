using System.IO;
using DevExpress.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Data;
using DevExpress.XtraCharts;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;
using MathNet.Numerics;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data.Enum;
using Sistema.Proctor.WinForm.Views.Proyecto.Reportes;
using DashStyle = DevExpress.XtraCharts.DashStyle;
using FillMode = DevExpress.XtraCharts.FillMode;
using Series = DevExpress.XtraCharts.Series;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Proctor
{
    public partial class ProctorControl : XtraUserControl
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private EnsayoProctor _EnsayoProctor;
        private int _Counter;
        private List<ResultadosProctor> ResultadosProctorList = new List<ResultadosProctor>();
        private readonly Enumeradores Enumeradores = new Enumeradores();

        public ProctorControl(EnsayoProctor ensayoProctor)
        {
            InitializeComponent();
            _EnsayoProctor = ensayoProctor;
            if (_EnsayoProctor.Idensayo <= 0)
            {
                _EnsayoProctor.DiametroMoldeCm = 15.2m;
                _EnsayoProctor.AlturaMoldeCm = 12.0m;
            }

            ensayoProctorBindingSource.DataSource = _EnsayoProctor;
            _Counter = 0;
            if (Enumeradores.PesoMartillo.Count > 0)
            {
                cmbPesoMartillo.Properties.Items.AddRange(Enumeradores.PesoMartillo);
            }

            if (Enumeradores.NumeroCapas.Count > 0)
            {
                cmbNumeroCapas.Properties.Items.AddRange(Enumeradores.NumeroCapas);
            }

            if (Enumeradores.GolpesPorCapa.Count > 0)
            {
                cmbGolpesPorCapa.Properties.Items.AddRange(Enumeradores.GolpesPorCapa);
            }

            if (Enumeradores.TemperaturaSecado.Count > 0)
            {
                cmbTemperaturaSecado.Properties.Items.AddRange(Enumeradores.TemperaturaSecado);
            }

            if (Enumeradores.TipoProctor.Count > 0)
            {
                cmbTipoProctor.Properties.Items.AddRange(Enumeradores.TipoProctor);
            }
            if (Enumeradores.Norma.Count > 0)
            {
                cmbNorma.Properties.Items.AddRange(Enumeradores.Norma);
            }

            if (Enumeradores.MetodoUtilizado.Count > 0)
            {
                cmbMetotoUtilizado.Properties.Items.AddRange(Enumeradores.MetodoUtilizado);
            }
        }

        private void tabResultadosProctor_CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                AddPage();
            }
        }

        private void AddPage(ResultadosProctor? resultadoProctor = null)
        {
            _Counter += 1;
            resultadoProctor ??= new ResultadosProctor();
            if (_EnsayoProctor.DiametroMoldeCm is not null && _EnsayoProctor.AlturaMoldeCm is not null)
            {
                var volumen = Formulas.VolumenCilindro((decimal)_EnsayoProctor.DiametroMoldeCm,
                    (decimal)_EnsayoProctor.AlturaMoldeCm);
                resultadoProctor.VolumenMolde = volumen;
            }
            else
            {
                resultadoProctor.VolumenMolde = decimal.Zero;
            }

            ResultadosProctorList.Add(resultadoProctor);
            var proctorResultados = new ProctorResultadosControl(resultadoProctor)
            {
                Dock = DockStyle.Fill
            };
            var xtraTabPage = new XtraTabPage()
            {
                Text = $@"Proctor {_Counter}",
                ShowCloseButton = DefaultBoolean.True
            };
            xtraTabPage.Controls.Clear();
            xtraTabPage.Controls.Add(proctorResultados);
            tabResultadosProctor.TabPages.Add(xtraTabPage);
            tabResultadosProctor.SelectedTabPage = xtraTabPage;
        }

        private async void ProctorControl_Load(object sender, EventArgs e)
        {
            try
            {
                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var resultadosProctorRepository = unitOfWork.ResultadosProctorRepository;
                if (_EnsayoProctor.Idensayo > 0)
                {
                    var resultados =
                        await resultadosProctorRepository.GetByCriteriaAsync(proctor =>
                            proctor.Idensayo == _EnsayoProctor.Idensayo);
                    foreach (var resultadosProctor in resultados)
                    {
                        AddPage(resultadosProctor);
                    }
                }
                else
                {
                    AddPage();
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }

        private void tabResultadosProctor_CloseButtonClick(object sender, EventArgs e)
        {
            if (tabResultadosProctor.TabPages.Count <= 0) return;
            if (e is not ClosePageButtonEventArgs arg) return;
            var xtraTabPage = arg.Page as XtraTabPage;
            var indexOf = tabResultadosProctor.TabPages.IndexOf(xtraTabPage);
            XtraMessageBox.Show($"Indice {indexOf}");
            ResultadosProctorList.RemoveAt(indexOf - 1);
            tabResultadosProctor.TabPages.Remove(xtraTabPage);
        }

        private void txtDiametroMoldeCm_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiametroMoldeCm.Text))
            {
                _EnsayoProctor.DiametroMoldeCm = decimal.Zero;
                return;
            }

            _EnsayoProctor.DiametroMoldeCm = decimal.Parse(txtDiametroMoldeCm.Text);
            if (_EnsayoProctor.AlturaMoldeCm is not null)
            {
                var volumen = Formulas.VolumenCilindro(_EnsayoProctor.DiametroMoldeCm.Value,
                    _EnsayoProctor.AlturaMoldeCm.Value);
                foreach (XtraTabPage tabPage in tabResultadosProctor.TabPages)
                {
                    var controlVolumen = tabPage.Controls.Find("txtVolumenMolde", true).FirstOrDefault();
                    if (controlVolumen is TextEdit edit)
                    {
                        edit.EditValue = volumen;
                    }
                }
            }
        }

        public async void btnGuardarEnsayoProctor_Click()
        {
            try
            {
                if (ResultadosProctorList.Count <= 3)
                {
                    XtraMessageBox.Show("Ingrese más datos para generar el gráfico", "Generar gráfico",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (DependenciasGlobalesForm.Instance.SelectedIdMuestra == 0)
                {
                    XtraMessageBox.Show("Seleccione la muestra a guardar el ensayo", "Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                splashScreenManager1.ShowWaitForm();
                using IUnitOfWork unitOfWork = new UnitOfWork();
                var usuario = DependenciasGlobalesForm.Instance.Usuario;
                var muestraRepository = unitOfWork.MuestrasRepository;
                var tipoEnsayoRepository = unitOfWork.TipoEnsayoRepository;
                var ensayoProctorRepository = unitOfWork.EnsayosProctorRepository;
                var ensayoRepository = unitOfWork.EnsayosRepository;
                var resultadoProctorRepository = unitOfWork.ResultadosProctorRepository;

                var tipoEnsayoProctor =
                    await tipoEnsayoRepository.GetFirstByCriteriaAsync(
                        tipoEnsayo => tipoEnsayo.Descripcion == "Proctor");
                if (tipoEnsayoProctor is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show(
                        "No existe el parametro del tipo de ensayo Proctor en la base de datos, genere el parametro de tipo de ensayo para continuar",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var muestra = await muestraRepository.GetByIdAsync(DependenciasGlobalesForm.Instance.SelectedIdMuestra);
                if (muestra is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("No hay muestra disponible en la base de datos con el codigo suministrado",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var ensayosByMuestra = await ensayoRepository.GetEnsayosByMuestra(muestra.Idmuestra);
                var ensayoRecordDto =
                    ensayosByMuestra.FirstOrDefault(dto => dto.IdTipoEnsayo == tipoEnsayoProctor.Idtipoensayo);

                if (ensayoRecordDto is null)
                {
                    var ensayo = new Ensayo
                    {
                        EdadReal = 0,
                        FechaIngreso = DateTime.Now,
                        FechaPrevista = DateTime.Now,
                        FechaReal = DateTime.Now,
                        Idempleado = muestra.Idempleado,
                        Idtipoensayo = tipoEnsayoProctor.Idtipoensayo,
                        Idmuestra = muestra.Idmuestra,
                    };
                    await ensayoRepository.AddAsync(ensayo);
                }

                var humedadOptimaList = new List<double>();
                var densidadMaximaList = new List<double>();

                _EnsayoProctor.Idempleado = muestra.Idempleado ?? 0;
                _EnsayoProctor.Idmuestra = muestra.Idmuestra;
                _EnsayoProctor.TemperaturaSecado = float.Parse(cmbTemperaturaSecado.SelectedItem.ToString()!);
                _EnsayoProctor.NumCapas = int.Parse(cmbNumeroCapas.SelectedItem.ToString()!);
                _EnsayoProctor.NumGolpes = int.Parse(cmbGolpesPorCapa.SelectedItem.ToString()!);
                _EnsayoProctor.PesoMartilloLb = float.Parse(cmbPesoMartillo.SelectedItem.ToString()!);
                _EnsayoProctor.Norma = cmbNorma.SelectedItem.ToString()!;
                _EnsayoProctor.TipoProctor = cmbTipoProctor.SelectedItem.ToString()!;
                _EnsayoProctor.MetodoUtilizado = cmbMetotoUtilizado.SelectedItem.ToString()!;
                if (_EnsayoProctor.Idensayo > 0)
                {
                    _EnsayoProctor.UpdatedBy = Convert.ToInt32(usuario.Idusuario);
                    _EnsayoProctor.UpdatedAt = DateTime.Now;
                    ensayoProctorRepository.Update(_EnsayoProctor);
                }
                else
                {
                    _EnsayoProctor.CreatedBy = Convert.ToInt32(usuario.Idusuario);
                    _EnsayoProctor.UpdatedBy = Convert.ToInt32(usuario.Idusuario);
                    var ensayoProctorEntry = await ensayoProctorRepository.AddAsync(_EnsayoProctor);
                    _EnsayoProctor = ensayoProctorEntry.Entity;
                }


                ResultadosProctorList.RemoveAll(proctor =>
                    proctor.DensidadSeca != null && proctor.DensidadSeca.Value.CompareTo(decimal.Zero) <= 0);
                foreach (var resultadosProctor in ResultadosProctorList)
                {
                    if (resultadosProctor.Idensayo == 0)
                    {
                        resultadosProctor.EnsayoProctor = _EnsayoProctor;
                    }

                    // Add values to the lists
                    humedadOptimaList.Add((double)(resultadosProctor.AguaAgregada ?? decimal.Zero));
                    densidadMaximaList.Add((double)(resultadosProctor.DensidadSeca ?? decimal.Zero));
                }

                // Ajuste polinómico de grado 5
                var coeficientes = Fit.Polynomial(humedadOptimaList.ToArray(), densidadMaximaList.ToArray(),
                    ResultadosProctorList.Count - 1);
                (var humedadOptima, var densidadMax) = Formulas.EncontrarMaximo(coeficientes, humedadOptimaList.Min(),
                    densidadMaximaList.Max());
                _EnsayoProctor.DensidadMaxima = (decimal)densidadMax;
                _EnsayoProctor.HumedadOptima = (decimal)humedadOptima;
                if (_EnsayoProctor.Idensayo > 0)
                {
                    foreach (var resultadosProctor in ResultadosProctorList)
                    {
                        resultadoProctorRepository.Update(resultadosProctor);
                    }
                }
                else
                {
                    await resultadoProctorRepository.AddRangeAsync(ResultadosProctorList);
                }

                await unitOfWork.CompleteAsync();
                splashScreenManager1.CloseWaitForm();
                await XtraMessageBox.ShowAsync("Se han guardado los datos de forma correcta");
            }
            catch (Exception e)
            {
                await XtraMessageBox.ShowAsync($"No fue posible guardar los datos, revise la siguiente información: {e.Message}");
                Logger.Error(e, "Error al guardar el ensayo de proctor");
            }
        }

        public void btnGenerarGrafico_Click()
        {
            if (ResultadosProctorList.Count <= 3)
            {
                XtraMessageBox.Show("Ingrese más datos para generar el gráfico", "Generar gráfico",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var humedad = new List<double>();
            var densidad = new List<double>();

            foreach (var resultadosProctor in ResultadosProctorList)
            {
                // Add values to the lists
                humedad.Add((double)(resultadosProctor.AguaAgregada ?? decimal.Zero));
                densidad.Add((double)(resultadosProctor.DensidadSeca ?? decimal.Zero));
            }

            var chart = new ChartControl()
            {
                Size = new Size(1300, 900)
            };

            // Ajuste polinómico de grado 5
            var coeficientes = Fit.Polynomial(humedad.ToArray(), densidad.ToArray(), ResultadosProctorList.Count - 1);

            // Encontrar la humedad óptima y la densidad máxima
            (var humedadOptima, var densidadMax) = Formulas.EncontrarMaximo(coeficientes, humedad.Min(), humedad.Max());


            // Crear serie de puntos originales
            var seriePuntos = new Series("Puntos de Ensayo", ViewType.Point);
            for (var i = 0; i < humedad.Count; i++)
                seriePuntos.Points.Add(new SeriesPoint(humedad[i], densidad[i]));

            // Crear serie de curva ajustada
            var serieCurva = new Series("Curva Ajustada", ViewType.Spline);
            for (var x = humedad.Min(); x <= humedad.Max(); x += 0.05)
            {
                var y = Formulas.EvaluatePolynomial(coeficientes, x);
                serieCurva.Points.Add(new SeriesPoint(x, y));
            }

            // Punto máximo de la curva
            var puntoMaximo = new Series("Óptimo de Compactación", ViewType.Point);
            puntoMaximo.Points.Add(new SeriesPoint(humedadOptima, densidadMax));
            puntoMaximo.View.Color = Color.Red;

            // Configurar el ChartControl
            chart.Series.Clear();
            chart.Series.AddRange(seriePuntos, serieCurva, puntoMaximo);

            // Configurar ejes
            var diagram = (XYDiagram)chart.Diagram;
            // Ajustar el rango del eje X
            var xMin = humedad.Min() - 1; // Mínimo de X con margen
            var xMax = humedad.Max() + 1; // Máximo de X con margen
            diagram.AxisX.VisualRange.SetMinMaxValues(xMin, xMax);
            diagram.AxisX.WholeRange.SetMinMaxValues(xMin, xMax);

            // Ajustar el rango del eje Y
            var yMin = densidad.Min() - 50; // Mínimo de Y con margen
            var yMax = densidad.Max() + 50; // Máximo de Y con margen
            diagram.AxisY.VisualRange.SetMinMaxValues(yMin, yMax);
            diagram.AxisY.WholeRange.SetMinMaxValues(yMin, yMax);
            diagram.AxisX.Title.Text = @"Humedad (%)";
            diagram.AxisY.Title.Text = @"Densidad Seca (kg/m³)";
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            diagram.AxisY.Title.Visibility = DefaultBoolean.True;

            // Mejorar visualización de la cuadrícula
            diagram.AxisX.GridLines.Visible = true;
            diagram.AxisY.GridLines.Visible = true;

            // Agregar marcador de línea en el punto máximo humedadOptima
            var lineHumedad = new ConstantLine(@"H Óptimo", humedadOptima);
            lineHumedad.Color = Color.Red;
            lineHumedad.LineStyle.DashStyle = DashStyle.Dot;
            lineHumedad.Title.Text = @$"Humedad Óptima: {humedadOptima:F2}%";
            diagram.AxisX.ConstantLines.Add(lineHumedad);

            // Agregar marcador de línea en el punto máximo densidadMax
            var lineProctor = new ConstantLine("D Max", densidadMax);
            lineProctor.Color = Color.Red;
            lineProctor.LineStyle.DashStyle = DashStyle.Dot;
            lineProctor.Title.Text = @$"Densidad Máxima: {densidadMax:F2} kg/m3";
            diagram.AxisY.ConstantLines.Add(lineProctor);

            // Configurar el gráfico
            chart.Dock = DockStyle.Fill;
            //var directorio = DependenciasGlobalesForm.Instance.CrearDirectorioEnDocumentos("GraficoProctor");
            //var fileName =
            //    $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.DayOfYear}{DateTime.Now.TimeOfDay.TotalMinutes}";
            //ImageOfChart = $"{directorio}/{fileName}.png";
            //chart.ExportToImage(ImageOfChart, DXImageFormat.Png);
            tabPageGrafico.Controls.Clear();
            tabPageGrafico.Controls.Add(chart);
            tabResultadosProctor.SelectedTabPage = tabPageGrafico;
        }


        public async void PrintReport()
        {
            btnGenerarGrafico_Click();
            var humedad = new List<double>();
            var densidad = new List<double>();

            foreach (var resultadosProctor in ResultadosProctorList)
            {
                // Add values to the lists
                humedad.Add((double)(resultadosProctor.AguaAgregada ?? decimal.Zero));
                densidad.Add((double)(resultadosProctor.DensidadSeca ?? decimal.Zero));
            }

            var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
            var resultadosEnsayoProctorRepository = unitOfWork.ResultadosEnsayoProctorRepository;
            var resultados =
                await resultadosEnsayoProctorRepository.GetResultadosEnsayoProctor(_EnsayoProctor.Idensayo);
            var reporteResultadosEnsayoProctor = new ReporteResultadosEnsayoProctor();

            var graficoProctor = reporteResultadosEnsayoProctor.graficoProctor;
            // Ajuste polinómico de grado 5
            var coeficientes = Fit.Polynomial(humedad.ToArray(), densidad.ToArray(), ResultadosProctorList.Count - 1);

            // Encontrar la humedad óptima y la densidad máxima
            (var humedadOptima, var densidadMax) = Formulas.EncontrarMaximo(coeficientes, humedad.Min(), humedad.Max());


            // Crear serie de puntos originales
            var seriePuntos = new Series("Puntos de Ensayo", ViewType.Point);
            var seriePuntosView = (PointSeriesView)seriePuntos.View;
            seriePuntosView.PointMarkerOptions.Size = 8;
            for (var i = 0; i < humedad.Count; i++)
                seriePuntos.Points.Add(new SeriesPoint(humedad[i], densidad[i]));

            // Crear serie de curva ajustada
            var serieCurva = new Series("Curva Ajustada", ViewType.Spline);
            var serieCurvaView = (LineSeriesView)serieCurva.View;
            serieCurvaView.MarkerVisibility = DefaultBoolean.False;
            for (var x = humedad.Min(); x <= humedad.Max(); x += 0.05)
            {
                var y = Formulas.EvaluatePolynomial(coeficientes, x);
                serieCurva.Points.Add(new SeriesPoint(x, y));
            }

            // Punto máximo de la curva
            var puntoMaximo = new Series("Óptimo de Compactación", ViewType.Point);
            puntoMaximo.Points.Add(new SeriesPoint(humedadOptima, densidadMax));
            puntoMaximo.View.Color = Color.Red;
            var puntoMaximoView = (PointSeriesView)puntoMaximo.View;
            puntoMaximoView.PointMarkerOptions.Size = 10;

            // Configurar el ChartControl
            graficoProctor.Series.Clear();
            seriePuntos.LabelsVisibility = DefaultBoolean.False;
            serieCurva.LabelsVisibility = DefaultBoolean.False;
            puntoMaximo.LabelsVisibility = DefaultBoolean.False;
            graficoProctor.Series.AddRange(seriePuntos, serieCurva, puntoMaximo);
            graficoProctor.Legend.Visibility = DefaultBoolean.False;
            // Configurar ejes
            var diagram = (XYDiagram)graficoProctor.Diagram;
            // Ajustar el rango del eje X
            var xMin = humedad.Min() - 1; // Mínimo de X con margen
            var xMax = humedad.Max() + 1; // Máximo de X con margen
            diagram.AxisX.VisualRange.SetMinMaxValues(xMin, xMax);
            diagram.AxisX.WholeRange.SetMinMaxValues(xMin, xMax);

            // Ajustar el rango del eje Y
            var dxFont = new DXFont("Arial", 9, DXFontStyle.Regular);
            var yMin = densidad.Min() - 50; // Mínimo de Y con margen
            var yMax = densidad.Max() + 50; // Máximo de Y con margen
            diagram.AxisY.VisualRange.SetMinMaxValues(yMin, yMax);
            diagram.AxisY.WholeRange.SetMinMaxValues(yMin, yMax);
            diagram.AxisX.Title.Text = @"Humedad (%)";
            diagram.AxisY.Title.Text = @"Densidad Seca (kg/m³)";
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
            diagram.AxisY.Title.Visibility = DefaultBoolean.True;
            diagram.AxisX.Title.DXFont = dxFont;
            diagram.AxisY.Title.DXFont = dxFont;

            // Mejorar visualización de la cuadrícula
            diagram.AxisX.GridLines.Visible = true;
            diagram.AxisY.GridLines.Visible = true;

            // Agregar marcador de línea en el punto máximo humedadOptima
            var lineHumedad = new ConstantLine(@"H Óptimo", humedadOptima);
            lineHumedad.Color = Color.Red;
            lineHumedad.LineStyle.DashStyle = DashStyle.Dot;
            lineHumedad.Title.Text = @$"Humedad Óptima: {humedadOptima:F2}%";
            diagram.AxisX.ConstantLines.Add(lineHumedad);

            // Agregar marcador de línea en el punto máximo densidadMax
            var lineProctor = new ConstantLine("D Max", densidadMax);
            lineProctor.Color = Color.Red;
            lineProctor.LineStyle.DashStyle = DashStyle.Dot;
            lineProctor.Title.Text = @$"Densidad Máxima: {densidadMax:F2} kg/m3";
            diagram.AxisY.ConstantLines.Add(lineProctor);
            foreach (var resultadosEnsayoProctorDto in resultados)
            {
                resultadosEnsayoProctorDto.NombreTranscribio = DependenciasGlobalesForm.Instance.Usuario.Nombre;
            }

            reporteResultadosEnsayoProctor.DataSource = resultados;
            var sucursal = DependenciasGlobalesForm.Instance.SelectedSucursal;
            if (sucursal.Logo.Length > 0)
            {
                reporteResultadosEnsayoProctor.xrPictureBox1.ImageSource = null;
                using var memory = new MemoryStream(sucursal.Logo);
                reporteResultadosEnsayoProctor.xrPictureBox1.ImageSource = new ImageSource(DXImage.FromStream(memory));
            }

            reporteResultadosEnsayoProctor.lblDireccionSucursal.Text = sucursal.Direccion;
            reporteResultadosEnsayoProctor.lblNombreSucursal.Text = sucursal.NombreComercial;
            reporteResultadosEnsayoProctor.lblEmailSucursal.Text = sucursal.Email;
            reporteResultadosEnsayoProctor.lblRepresentante.Text = sucursal.Representante;
            var designTool = new ReportPrintTool(reporteResultadosEnsayoProctor);
            designTool.ShowRibbonPreview();
        }
    }
}