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
        // Obtiene la clave primaria de la entidad
        var entityType = _context.Model.FindEntityType(typeof(T));
        var key = entityType.FindPrimaryKey();
        var keyProperties = key.Properties.Select(p => p.Name).ToList();

        // Obtiene los valores de la clave primaria de la entidad
        var keyValues = keyProperties.Select(k => typeof(T).GetProperty(k).GetValue(entity)).ToArray();

        var local = _context.Set<T>().Find(keyValues);

        if (local != null)
        {
            // Actualiza los valores de la entidad existente
            _context.Entry(local).CurrentValues.SetValues(entity);
        }
        else
        {
            // Si no está siendo rastreada, la actualizamos
            _context.Update(entity);
        }
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

    public void UpdateRangeAsync(List<T> range)
    {
        _context.UpdateRange(range);
    }
}