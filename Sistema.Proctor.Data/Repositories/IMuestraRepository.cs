using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IMuestraRepository : IRepository<Muestra>
{
    Task<List<Muestra>> GetMuestraByProyecto(int idProyecto);
    Task AddMuestraTask(Muestra muestra);
}