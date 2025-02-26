using DevExpress.XtraEditors;
using NLog;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Helpers;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Empresa
{
    public partial class EmpresaEdit : EditForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private EmpresaDto SelectedEmpresaDto;

        public EmpresaEdit()
        {
            InitializeComponent();
            if (DependenciasGlobalesForm.Instance.SelectedEmpresa is null)
            {
                SelectedEmpresaDto = new();
                IsNew = true;
            }
            else
            {
                SelectedEmpresaDto = new EmpresaDto().GetEmpresaDto(DependenciasGlobalesForm.Instance.SelectedEmpresa);
                IsNew = false;
            }
            empresaDtoBindingSource.DataSource = SelectedEmpresaDto;
            dxErrorProvider1.DataSource = empresaDtoBindingSource;
            dxErrorProvider1.ContainerControl = this;
        }

        private void EmpresaEdit_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void LoadImage()
        {
            var recuperarImagen = HelperMethods.RecuperarImagen(SelectedEmpresaDto.Logo);
            if (recuperarImagen is not null)
            {
                txtLogo.Image = recuperarImagen;
            }
        }

        private void txtLogo_ImageLoading(object sender, DevExpress.XtraEditors.Repository.SaveLoadImageEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.FileName))
            {
                return;
            }

            try
            {
                // Leer el archivo de imagen y asignarlo a SelectedEmpresaDto.Logo
                SelectedEmpresaDto.Logo = System.IO.File.ReadAllBytes(e.FileName);
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, mostrar un mensaje al usuario)
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxErrorProvider1.HasErrors)
                {
                    return;
                }
                var empresa = SelectedEmpresaDto.GetEmpresa();
                var usuario = DependenciasGlobalesForm.Instance.Usuario;
                using IUnitOfWork unitOfWork = new UnitOfWork();
                var empresaRepository = unitOfWork.EmpresaRepository;
                if (IsNew)
                {
                    empresa.CreatedBy = (int?)usuario.Idusuario;
                    await empresaRepository.AddAsync(empresa);
                }
                else
                {
                    empresa.UpdatedAt=DateTime.Now;
                    empresaRepository.Update(empresa);
                }

                await unitOfWork.CompleteAsync();
                XtraMessageBox.Show("Se ha ingresado la empresa de forma correcta", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DependenciasGlobalesForm.Instance.FillListadoEmpresas();
                Close();
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error al guardar la empresa");
            }
        }
    }
}