using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Proyecto> ProyectoRepository { get; }
    IRepository<Muestra> MuestrasRepository { get; }
    IRepository<EnsayoProctor> EnsayosProctorRepository { get; }
    Task<int> CompleteAsync();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContextProctor Context;
    private bool Disposed;
    public UnitOfWork(DataContextProctor context)
    {
        Context = context;
        ProyectoRepository = new Repository<Proyecto>(Context);
        MuestrasRepository = new Repository<Muestra>(Context);
        EnsayosProctorRepository = new Repository<EnsayoProctor>(Context);
    }

    public IRepository<Proyecto> ProyectoRepository { get; private set; }
    public IRepository<Muestra> MuestrasRepository { get; private set; }
    public IRepository<EnsayoProctor> EnsayosProctorRepository { get; private set; }

    public async Task<int> CompleteAsync()
    {
        await using var transaction = await Context.Database.BeginTransactionAsync();
        try
        {
            var result = await Context.SaveChangesAsync();
            await transaction.CommitAsync();
            return result;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw; // Relanza la excepción para manejarla en una capa superior
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (Disposed) return;
        if (disposing)
        {
            Context.Dispose();
        }
        Disposed = true;
    }
}