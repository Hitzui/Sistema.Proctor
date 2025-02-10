using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Cliente
{
    public partial class SelectClienteDialog : EditForm
    {
        public SelectClienteDialog()
        {
            InitializeComponent();
            btnCancelar.Click += (sender, args) =>
            {
                DependenciasGlobalesForm.Instance.SelectedCliente = null; 
            };
            gridControlSelectCliente.DataSource = DependenciasGlobalesForm.Instance.ListadoClientes;
        }

        private void gridViewSelectCliente_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var handle = gridViewSelectCliente.FocusedRowHandle;
            if (!gridViewSelectCliente.IsValidRowHandle(handle)) return;
            var cliente = (Proctor.Data.Entities.Cliente)gridViewSelectCliente.GetRow(handle);
            DependenciasGlobalesForm.Instance.SelectedCliente = new ClienteDto().GetClienteDto(cliente);
        }

        private void SelectClienteDialog_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            DependenciasGlobalesForm.Instance.FillListadoClientes();
            splashScreenManager1.CloseWaitForm();
        }
    }
}