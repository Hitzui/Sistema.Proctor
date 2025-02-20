using DevExpress.XtraEditors;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Cliente;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Proyecto
{
    public partial class ProyectoEdit : EditForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private Sistema.Proctor.Data.Entities.Cliente? SelectedCliente;
        private bool isNew;

        public ProyectoEdit()
        {
            InitializeComponent();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            var selecClienteDialog = new SelectClienteDialog();
            var result = selecClienteDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            if (DependenciasGlobalesForm.Instance.SelectedCliente is null)
            {
                return;
            }

            SelectedCliente = DependenciasGlobalesForm.Instance.SelectedCliente.GetCliente();
            txtClienteDescripcion.Text = SelectedCliente.NombreComercial;
        }

        private void ProyectoEdit_Load(object sender, EventArgs e)
        {
            if (DependenciasGlobalesForm.Instance.SelectedProyecto is not null)
            {
                proyectoDtoBindingSource.DataSource = DependenciasGlobalesForm.Instance.SelectedProyecto;
                SelectedCliente = DependenciasGlobalesForm.Instance.SelectedProyecto.Cliente;
                if (SelectedCliente is not null)
                {
                    txtClienteDescripcion.Text = SelectedCliente.NombreComercial;
                }

                isNew = false;
            }
            else
            {
                proyectoDtoBindingSource.DataSource = new ProyectoDto();
                isNew = true;
            }

            dxErrorProvider1.DataSource = proyectoDtoBindingSource;
            dxErrorProvider1.ContainerControl = this;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var res = XtraMessageBox.Show("¿Guardar los datos del proyecto?", "Guardar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    return;
                }

                if (dxErrorProvider1.HasErrors)
                {
                    XtraMessageBox.Show("No se puede guardar el proyecto, hay errores en los campos");
                    return;
                }

                if (SelectedCliente is null)
                {
                    XtraMessageBox.Show("NO ha seleccionado un cliente, intente nuevamente", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (proyectoDtoBindingSource.Current is not ProyectoDto proyecto) return;
                using IUnitOfWork unitOfWork = new UnitOfWork();
                var proyectoRepository = unitOfWork.ProyectoRepository;

                var saveProyecto = proyecto.GetProyecto();
                var usuario = DependenciasGlobalesForm.Instance.Usuario;
                
                if (isNew)
                {
                    saveProyecto.Cliente = SelectedCliente;
                    saveProyecto.CreatedBy = (int?)usuario.Idusuario;
                    saveProyecto.UpdatedBy = (int?)usuario.Idusuario;
                    await proyectoRepository.AddAsync(saveProyecto);
                }
                else
                {
                    saveProyecto.Idcliente = SelectedCliente.Idcliente;
                    saveProyecto.UpdatedBy = (int?)usuario.Idusuario;
                    saveProyecto.UpdatedAt = DateTime.Now;
                    proyectoRepository.Update(saveProyecto);
                }

                try
                {
                    await proyectoRepository.SaveAsync();
                    await XtraMessageBox.ShowAsync("Se han guardado los datos del proyecto de forma correcta");
                    DependenciasGlobalesForm.Instance.FillListadoProyectos();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception exception)
                {
                    await XtraMessageBox.ShowAsync($"No fue posible guardar el proyecto: {exception.Message}");
                    Logger.Error(exception, "Error al guardar el proyecto");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al guardar el proyecto");
            }
        }
    }
}