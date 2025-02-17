using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Sistema.Proctor.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DataContextProctor _context;

    public Repository(DataContextProctor context)
    {
        _context = context;
    }

    public Task<List<T>> GetAllAsync()
    {
        return _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public ValueTask<T?> GetByIdAsync(int id)
    {
        return _context.Set<T>().FindAsync(id);
    }

    public ValueTask<EntityEntry<T>> AddAsync(T entity)
    {
        return _context.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public Task SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    // Método para consultar por criterio
    public Task<List<T>> GetByCriteriaAsync(Expression<Func<T, bool>> criteria)
    {
        return _context.Set<T>().Where(criteria).AsNoTracking().ToListAsync();
    }

    // Método para obtener un solo elemento por criterio
    public Task<T?> GetFirstByCriteriaAsync(Expression<Func<T, bool>> criteria)
    {
        return _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(criteria);
    }

    public Task AddRangeAsync(List<T> range)
    {
        return _context.AddRangeAsync(range);
    }
}