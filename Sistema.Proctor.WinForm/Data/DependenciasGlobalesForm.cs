using System.Collections.ObjectModel;
using System.Windows.Threading;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using Sistema.Proctor.Data;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.Data.Repositories;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Data;

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
        _listadoProyectos = new();
        _listadoMuestras = new();
        _listadoEnsayosMuestras = new();
    }

    public T? GetService<T>()
    {
        return serviceProvider.GetService<T>();
    }

    private ObservableCollection<Cliente> _listadoClientes;
    public ObservableCollection<Cliente> ListadoClientes => _listadoClientes;

    private ObservableCollection<Empleado> _listadoEmpleados;
    public ObservableCollection<Empleado> ListadoEmpleados => _listadoEmpleados;

    private ObservableCollection<Proyecto> _listadoProyectos;
    public ObservableCollection<Proyecto> ListadoProyectos => _listadoProyectos;

    private ObservableCollection<Muestra> _listadoMuestras;
    public ObservableCollection<Muestra> ListadoMuestras => _listadoMuestras;

    private ObservableCollection<Ensayo> _listadoEnsayosMuestras;
    public ObservableCollection<Ensayo> ListadoEnsayosMuestras => _listadoEnsayosMuestras;

    public async void FillListadoClientes()
    {
        try
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
        }
        catch (Exception e)
        {
            Logger.Error(e, "Error al cargar la lista de Clientes");
        }
    }

    public async void FillListadoEmpleados()
    {
        try
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
        }
        catch (Exception e)
        {
            Logger.Error(e, "Error al cargar la lista de Empleados");
        }
    }

    public async void FillListadoProyectos()
    {
        try
        {
            var proyectoRepository = DependenciasGlobales.Instance.GetService<IProyectoRepository>();
            var listado = await proyectoRepository.FindByDateList();
            ListadoProyectos.Clear();
            if (listado.Count <= 0) return;
            foreach (var proyecto in listado)
            {
                ListadoProyectos.Add(proyecto);
            }
        }
        catch (Exception e)
        {
            Logger.Error(e, "Error al cargar la lista de Proyectos");
        }
    }

    public async Task FillListadoMuestras(int idProyectos)
    {
        var muestraRepository = DependenciasGlobales.Instance.GetService<IMuestraRepository>();
        var listado = await muestraRepository.GetMuestraByProyecto(idProyectos);
        ListadoMuestras.Clear();
        if (listado.Count <= 0) return;
        foreach (var muestra in listado)
        {
            ListadoMuestras.Add(muestra);
        }
    }


    public ClienteDto? SelectedCliente { get; set; }
    public EmpleadoDto? SelectedEmpleado { get; set; }
    public ProyectoDto? SelectedProyecto { get; set; }
    public int SelectedIdMuestra { get; set; } = 0;
}