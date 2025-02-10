using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Views.Cliente
{
    public partial class ClientesList : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ClientesList()
        {
            InitializeComponent();
        }

        private void ClientesList_Load(object sender, EventArgs e)
        {
            BeginInvoke(() =>
            {
                splashScreenManager1.ShowWaitForm();
                LoadData();
                splashScreenManager1.CloseWaitForm();
            });
        }

        private void LoadData()
        {
            try
            {
                gridControlClientes.DataSource = DependenciasGlobalesForm.Instance.ListadoClientes;
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al cargar los datos del cliente, Lista");
            }
        }

        private void gridViewClientes_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var selectedRowsCount = gridViewClientes.SelectedRowsCount;
            if (selectedRowsCount > 0)
            {
                var cliente = (Proctor.Data.Entities.Cliente)gridViewClientes.GetRow(gridViewClientes.FocusedRowHandle);
                DependenciasGlobalesForm.Instance.SelectedCliente = new ClienteDto().GetClienteDto(cliente);
            }
        }

        private void gridViewClientes_PopupMenuShowing(object sender,
            DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                e.ShowCustomMenu(popupMenuClientes);
            }
        }

        private void barManagerClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item == barButtonItemEditar)
            {
                var clienteEdit = new ClienteEdit();
                clienteEdit.ShowDialog();
            }

            if (e.Item == barButtonItemEliminar)
            {
                EliminarCliente();
            }
        }

        public async void EliminarCliente()
        {
            try
            {
                var result =
                    XtraMessageBox.Show("¿Seguro eliminará el cliente seleccionado? Esta acción no se puede revertir",
                        "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }

                var cliente = DependenciasGlobalesForm.Instance.SelectedCliente;
                if (cliente is null)
                {
                    await XtraMessageBox.ShowAsync("No ha seleccionado un cliente");
                    return;
                }

                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var repositorio = unitOfWork.ClienteRepository;
                repositorio.Delete(cliente.GetCliente());
                await unitOfWork.CompleteAsync();
                DependenciasGlobalesForm.Instance.FillListadoClientes();
                await XtraMessageBox.ShowAsync("Se ha eliminado el cliente de forma correcta");
            }
            catch (Exception e)
            {
                Logger.Error(e, "Error al eliminar el cliente");
            }
        }
    }
}