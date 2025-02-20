using DevExpress.XtraEditors;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Empleado;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;

namespace Sistema.Proctor.WinForm.Views.Proyecto.Muestra
{
    public partial class AgregarMuestra : XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private MuestraDto? _Muestra;

        public AgregarMuestra()
        {
            InitializeComponent();
            _Muestra = new MuestraDto();
            muestraDtoBindingSource.DataSource = _Muestra;
            dxErrorProvider.DataSource = muestraDtoBindingSource;
            dxErrorProvider.ContainerControl = this;
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            var selectEmpleadoDialog = new SelectEmpleadoDialog();
            var dialogResult = selectEmpleadoDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            var empleadoSeleccionado = selectEmpleadoDialog.EmpleadoSeleccionado;
            if (empleadoSeleccionado is null)
            {
                XtraMessageBox.Show("No se ha seleccionado un empleado", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            txtEmpleadoNombre.Text = $@"{empleadoSeleccionado.Nombre} {empleadoSeleccionado.Apellido}";
            _Muestra.Idempleado = empleadoSeleccionado.Idempleado;
            _Muestra.Empleado = empleadoSeleccionado;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxErrorProvider.HasErrors)
                {
                    XtraMessageBox.Show("Debe rellenar todos los campos para guardar los datos de la muestra", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedProyecto = DependenciasGlobalesForm.Instance.SelectedProyecto;
                if (selectedProyecto is null)
                {
                    Logger.Error("AgregarMuestra: Linea 45 Se accedio a la pantalla pero el proyecto era null");
                    XtraMessageBox.Show("No se ha seleccionado un proyecto para guardar la muestra", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var usuario = DependenciasGlobalesForm.Instance.Usuario;
                _Muestra = muestraDtoBindingSource.DataSource as MuestraDto;
                _Muestra.Idproyecto = selectedProyecto.Idproyecto;
                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var muestraRepository = unitOfWork.MuestrasRepository; 
                var muestra = _Muestra.GetMuestra();
                muestra.CreatedBy = Convert.ToInt32(usuario.Idusuario);
                muestra.UpdatedBy = Convert.ToInt32(usuario.Idusuario);
                await muestraRepository.AddAsync(muestra);
                var completeAsync = await unitOfWork.CompleteAsync();
                if (completeAsync>0)
                {
                    XtraMessageBox.Show("Muestra guardada correctamente", "Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("No se pudo guardar la muestra, debido a un error interno", "Guardar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar la muestra");
            }
        }
    }
}