using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IUnitOfWork
{

    IRepository<Cliente> ClienteRepository { get; }
    IRepository<Empleado> EmpleadoRepository { get; }
    IRepository<Proyecto> ProyectoRepository { get; }
    IRepository<Muestra> MuestrasRepository { get; }
    IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    Task<int> CompleteAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContextProctor _Context;
    private bool _Disposed;
    public UnitOfWork(DataContextProctor context)
    {
        _Context = context;
        ClienteRepository = new Repository<Cliente>(_Context);
        ProyectoRepository = new Repository<Proyecto>(_Context);
        MuestrasRepository = new Repository<Muestra>(_Context);
        EmpleadoRepository = new Repository<Empleado>(_Context);
        EnsayosProctorRepository = new Repository<EnsayoProctor>(_Context);
    }

    public IRepository<Cliente> ClienteRepository { get; }
    public IRepository<Proyecto> ProyectoRepository { get; }
    public IRepository<Muestra> MuestrasRepository { get; }
    public IRepository<Empleado> EmpleadoRepository { get; }

    public IRepository<EnsayoProctor> EnsayosProctorRepository { get; }

    public async Task<int> CompleteAsync()
    {
        await using var transaction = await _Context.Database.BeginTransactionAsync();
        try
        {
            var result = await _Context.SaveChangesAsync();
            await transaction.CommitAsync();
            return result;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
        finally
        {
            _Context.ChangeTracker.Clear();
        }
    }

}