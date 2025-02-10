using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IUnitOfWork
{

    IRepository<Cliente> ClienteRepository { get; }
    IRepository<Empleado> EmpleadoRepository { get; }
    IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    IRepository<Ensayo> EnsayosRepository { get; }
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
        EmpleadoRepository = new Repository<Empleado>(_Context);
        EnsayosProctorRepository = new Repository<EnsayoProctor>(_Context);
        EnsayosRepository = new Repository<Ensayo>(_Context);
    }

    public IRepository<Cliente> ClienteRepository { get; }
    public IMuestraRepository MuestrasRepository { get; }
    public IRepository<Empleado> EmpleadoRepository { get; }
    public IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    public IRepository<Ensayo> EnsayosRepository { get; }

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