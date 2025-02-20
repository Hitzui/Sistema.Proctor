using DevExpress.XtraEditors;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Data;
using Sistema.Proctor.WinForm.Dto;
using Sistema.Proctor.WinForm.Views.Template;

namespace Sistema.Proctor.WinForm.Views.Cliente
{
    public partial class ClienteEdit : EditForm
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private ClienteDto? _Cliente;

        public ClienteEdit()
        {
            InitializeComponent();
        }

        private void LoadValues()
        {
            var instanceSelectedCliente = DependenciasGlobalesForm.Instance.SelectedCliente;
            if (instanceSelectedCliente is null)
            {
                _Cliente = new ClienteDto();
                IsNew = true;
            }
            else
            {
                _Cliente = instanceSelectedCliente;
                IsNew = false;
            }

            clienteBindingSource.DataSource = _Cliente;
            dxErrorProvider1.DataSource = clienteBindingSource;
            dxErrorProvider1.ContainerControl = this;
        }

        private void ClienteEdit_Load(object sender, EventArgs e)
        {
            LoadValues();
        }

        private async void btnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dxErrorProvider1.HasErrors)
                {
                    await XtraMessageBox.ShowAsync("Llenar todos los campos para poder continuar");
                    return;
                }

                var confirm = XtraMessageBox.Show("¿Guardar datos del Cliente?", "Guardar", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (confirm == DialogResult.Cancel)
                {
                    return;
                }

                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                try
                {
                    var clienteRepositorio = unitOfWork!.ClienteRepository;
                    var currentCliente = (ClienteDto)clienteBindingSource.Current!;
                    var cliente = currentCliente.GetCliente();
                    if (IsNew)
                    {
                        cliente.FIngreso = DateTime.Now;
                        await clienteRepositorio.AddAsync(cliente);
                    }
                    else
                    {
                        clienteRepositorio.Update(cliente);
                    }

                    await unitOfWork.CompleteAsync();

                    if (IsNew)
                    {
                        DependenciasGlobalesForm.Instance.ListadoClientes.Add(currentCliente.GetCliente());
                    }
                    else
                    {
                        DependenciasGlobalesForm.Instance.FillListadoClientes();
                    }

                    await XtraMessageBox.ShowAsync("Se han guardado los datos de forma correcta");
                    Close();
                }
                catch (Exception exception)
                {
                    Logger.Error(exception, "Error al guardar cliente");
                    await XtraMessageBox.ShowAsync("No fue posible guardar los datos del cliente");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error al guardar Cliente Try Superior");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}