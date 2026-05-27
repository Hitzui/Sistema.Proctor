using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NLog;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IUnitOfWork : IDisposable
{
    IMuestraRepository MuestrasRepository { get; }
    IRepository<Cliente> ClienteRepository { get; }
    IRepository<Empleado> EmpleadoRepository { get; }
    IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    IRepository<ResultadosProctor> ResultadosProctorRepository { get; }
    IRepository<TipoEnsayo> TipoEnsayoRepository { get; }
    IEnsayoRepository EnsayosRepository { get; }
    IResultadosEnsayoProctorRepository ResultadosEnsayoProctorRepository { get; }
    IProyectoRepository ProyectoRepository { get; }
    IUsuarioRepository UsuarioRepository { get; }
    IEmpresaRepository EmpresaRepository { get; }
    IEnsayoHumedadRepository EnsayoHumedadRepository{ get; }
    IResultadoEnsayoHumedadRepository ResultadoEnsayoHumedadRepository { get; }
    Task<Parametro?> Parametros();
    Task<int> CompleteAsync();
    Task<IDbContextTransaction> BeginTransaction();
    Task<int> PreviewSaveChanges();
    void ClearTracking();
}

public class UnitOfWork : IUnitOfWork, IAsyncDisposable
{
    private readonly DataContextProctor _Context;
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    public UnitOfWork()
    {
        _Context = new DataContextProctor();
        ClienteRepository = new Repository<Cliente>(_Context);
        EmpleadoRepository = new Repository<Empleado>(_Context);
        EnsayosProctorRepository = new Repository<EnsayoProctor>(_Context);
        EnsayosRepository = new EnsayoRepository(_Context);
        ResultadosProctorRepository = new Repository<ResultadosProctor>(_Context);
        MuestrasRepository = new MuestraRepository(_Context);
        TipoEnsayoRepository = new Repository<TipoEnsayo>(_Context);
        ResultadosEnsayoProctorRepository = new ResultadosEnsayoProctorRepository(_Context);
        ProyectoRepository = new ProyectoRepository(_Context);
        UsuarioRepository = new UsuarioRepository(_Context);
        EmpresaRepository = new EmpresaRepository(_Context);
        EnsayoHumedadRepository = new EnsayoHumedadRepository(_Context);
        ResultadoEnsayoHumedadRepository = new ResultadoEnsayoHumedadRepository(_Context);
    }

    public IRepository<Cliente> ClienteRepository { get; }
    public IMuestraRepository MuestrasRepository { get; }
    public IRepository<Empleado> EmpleadoRepository { get; }
    public IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    public IRepository<ResultadosProctor> ResultadosProctorRepository { get; }
    public IEnsayoRepository EnsayosRepository { get; }
    public IRepository<TipoEnsayo> TipoEnsayoRepository { get; }
    public IResultadosEnsayoProctorRepository ResultadosEnsayoProctorRepository { get; }
    public IProyectoRepository ProyectoRepository { get; }
    public IUsuarioRepository UsuarioRepository { get; }
    public IEmpresaRepository EmpresaRepository { get; }
    public IEnsayoHumedadRepository EnsayoHumedadRepository{ get; }
    public IResultadoEnsayoHumedadRepository ResultadoEnsayoHumedadRepository { get; }

    private IDbContextTransaction? _transaction;

    public async Task<IDbContextTransaction> BeginTransaction()
    {
        _transaction= await _Context.Database.BeginTransactionAsync();
        return _transaction;
    }
    
    public Task<Parametro?> Parametros()
    {
        return _Context.Parametros.AsNoTracking().FirstOrDefaultAsync();
    }

    public Task<int> PreviewSaveChanges()
    {
        return _Context.SaveChangesAsync();
    }
    public async Task<int> CompleteAsync()
    {
        _transaction ??= await _Context.Database.BeginTransactionAsync();
        try
        {
            var result = await _Context.SaveChangesAsync();
            await _transaction.CommitAsync();
            return result;
        }
        catch
        {
            await _transaction.RollbackAsync();
            throw;
        }
        finally
        {
            _Context.ChangeTracker.Clear();
        }
    }

    public void ClearTracking()
    {
        _Context.ChangeTracker.Clear();
    }

    public void Dispose()
    {
        _Context.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        await _Context.DisposeAsync();
    }
}