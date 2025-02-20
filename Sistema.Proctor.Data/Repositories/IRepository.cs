using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
    ValueTask<T?> GetByIdAsync(int id);
    ValueTask<EntityEntry<T>> AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveAsync();
    Task<List<T>> GetByCriteriaAsync(Expression<Func<T, bool>> criteria);
    Task<T?> GetFirstByCriteriaAsync(Expression<Func<T, bool>> criteria);
    Task AddRangeAsync(List<T> range);
    void UpdateRangeAsync(List<T> range);
}