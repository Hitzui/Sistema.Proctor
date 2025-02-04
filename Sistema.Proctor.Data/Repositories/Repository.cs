using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Entities;

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

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}