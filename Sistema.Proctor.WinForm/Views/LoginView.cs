using DevExpress.UITemplates.Collection.Utilities;
using DevExpress.XtraEditors;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;

namespace Sistema.Proctor.WinForm.Views
{
    public partial class LoginView : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public LoginView()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var usuarioRepository = unitOfWork.UsuarioRepository;
                if (string.IsNullOrWhiteSpace(txtEmail.Email))
                {
                    errorProvider1.SetError(txtEmail, "Debe especificar este campo");
                    return;
                }

                errorProvider1.SetError(txtEmail, "");

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Debe especificar este campo");
                    return;
                }

                errorProvider1.SetError(txtPassword, "");
                splashScreenManager1.ShowWaitForm();
                var usuario = await usuarioRepository.GetByUsernameAsync(txtEmail.Text);
                if (usuario is null)
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("No existe el usuario con este correo", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!BCrypt.Net.BCrypt.Verify(txtPassword.Text, usuario.Password))
                {
                    splashScreenManager1.CloseWaitForm();
                    XtraMessageBox.Show("Contraseña incorrecta, intente nuevamente", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Inicio de sesión correcto. Bienvenido al Sistema de Gestion de laboratorio", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DependenciasGlobalesForm.Instance.Usuario = usuario;
                DialogResult = DialogResult.Yes;
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }
    }
}