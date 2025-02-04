using System.Collections.ObjectModel;
using System.Windows.Threading;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.Data;

public class DependenciasGlobalesForm
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private static readonly Lazy<DependenciasGlobalesForm> instance = new(() => new DependenciasGlobalesForm());

    public static DependenciasGlobalesForm Instance => instance.Value;

    private readonly IServiceProvider serviceProvider;

    private DependenciasGlobalesForm()
    {
        // Configurar el contenedor de DI
        var serviceCollection = new ServiceCollection();
        serviceProvider = serviceCollection.BuildServiceProvider();
        _listadoClientes = new();
        _listadoEmpleados = new();
    }

    public T? GetService<T>()
    {
        return serviceProvider.GetService<T>();
    }

    private ObservableCollection<Cliente> _listadoClientes;
    public ObservableCollection<Cliente> ListadoClientes => _listadoClientes;

    private ObservableCollection<Empleado> _listadoEmpleados;
    public ObservableCollection<Empleado> ListadoEmpleados => _listadoEmpleados;

    public void FillListadoClientes()
    {
        try
        {
            Dispatcher.CurrentDispatcher.Invoke(async () =>
            {
                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var repositorioCliente = unitOfWork.ClienteRepository;
                var listado = await repositorioCliente.GetAllAsync();
                ListadoClientes.Clear();
                if (listado.Count <= 0) return;
                foreach (var cliente in listado)
                {
                    ListadoClientes.Add(cliente);
                }
            });
            
        }
        catch (Exception e)
        {
           Logger.Error(e, "Error al cargar la lista de Clientes");
        }
    }

    public void FillListadoEmpleados()
    {
        try
        {
            Dispatcher.CurrentDispatcher.Invoke(async () =>
            {
                var unitOfWork = DependenciasGlobales.Instance.GetService<IUnitOfWork>();
                var empleadoRepository = unitOfWork.EmpleadoRepository;
                var listado = await empleadoRepository.GetAllAsync();
                ListadoEmpleados.Clear();
                if (listado.Count <= 0) return;
                foreach (var empleado in listado)
                {
                    ListadoEmpleados.Add(empleado);
                }
            });
            
        }
        catch (Exception e)
        {
            Logger.Error(e, "Error al cargar la lista de Clientes");
        }
    }

    public ClienteDto? SelectedCliente { get; set; }
    public EmpleadoDto? SelectedEmpleado { get; set; }
}