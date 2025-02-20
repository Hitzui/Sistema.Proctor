using DevExpress.XtraEditors;
using Sistema.Proctor.WinForm.Views;

namespace Sistema.Proctor.WinForm;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        using var frmLogin = new LoginView();
        if (frmLogin.ShowDialog( )== DialogResult.Yes)
        {
            Application.Run(new MainView());
        }
    }
}