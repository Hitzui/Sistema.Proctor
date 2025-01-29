namespace Sistema.Proctor.Data.Repositories;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
    ValueTask<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveAsync();
}