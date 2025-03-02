using System.Collections.ObjectModel;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Threading;
using DevExpress.XtraEditors;
using Microsoft.Extensions.Configuration;
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
        _ListadoEmpresas = new();
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
    private ObservableCollection<Empresa> _ListadoEmpresas;
    public  ObservableCollection<Empresa> ListadoEmpresas => _ListadoEmpresas;

    public string GetConnectionString(string connectionStringName)
    {
        var configurationBuilder =
            new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
        var configuration = configurationBuilder.Build();
        return configuration.GetConnectionString(connectionStringName)!;
    }

    public async Task<MuestraDto?> GetMuestraDto()
    {
        if (SelectedIdMuestra==0)
        {
            return null;
        }

        using IUnitOfWork unitOfWork = new UnitOfWork();
        var muestraRepository = unitOfWork.MuestrasRepository;
        var muestra = await 
            muestraRepository.GetFirstByCriteriaAsync(muestra1 => muestra1.Idmuestra == SelectedIdMuestra);
        return muestra is null ? null : new MuestraDto().GetMuestraDto(muestra);
    }
    public async void FillListadoEmpresas()
    {
        try
        {
            using IUnitOfWork unitOfWork = new UnitOfWork();
            var empresaRepository = unitOfWork.EmpresaRepository;
            var listado = await empresaRepository.GetListByActiva();
            ListadoEmpresas.Clear();
            foreach (var empresa in listado)
            {
                ListadoEmpresas.Add(empresa);
            }
        }
        catch (Exception exception)
        {
            Logger.Error(exception, "Error al cargar la lista de empresas");
        }
    }
    public async void FillListadoClientes()
    {
        try
        {
            using IUnitOfWork unitOfWork = new UnitOfWork();
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
            using IUnitOfWork unitOfWork = new UnitOfWork();
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
            using IUnitOfWork unitOfWork = new UnitOfWork();
            var proyectoRepository = unitOfWork.ProyectoRepository;
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
        using IUnitOfWork unitOfWork = new UnitOfWork();
        var muestraRepository = unitOfWork.MuestrasRepository;
        var listado = await muestraRepository.GetMuestraByProyecto(idProyectos);
        ListadoMuestras.Clear();
        if (listado.Count <= 0) return;
        foreach (var muestra in listado)
        {
            ListadoMuestras.Add(muestra);
        }
    }

    public string CrearDirectorioEnDocumentos(string namePath)
    {
        // Obtener la ruta de la carpeta "Documentos" del usuario
        var rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var rutaDirectorio = Path.Combine(rutaDocumentos, namePath);


        if (!Directory.Exists(rutaDirectorio))
        {
            Directory.CreateDirectory(rutaDirectorio);
        }

        var attributes = File.GetAttributes(rutaDirectorio);
        if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        {
            
        }


        return rutaDirectorio;
    }

    public ClienteDto? SelectedCliente { get; set; }
    public EmpleadoDto? SelectedEmpleado { get; set; }
    public ProyectoDto? SelectedProyecto { get; set; }
    public int SelectedIdMuestra { get; set; }
    public Usuario Usuario { get; set; }
    public Empresa? SelectedEmpresa { get; set; }
    public EmpresaDto SelectedSucursal { get; set; }
}