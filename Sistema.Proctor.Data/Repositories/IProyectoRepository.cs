using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IProyectoRepository : IRepository<Proyecto>
{
    Task<List<Proyecto>> FindByDateList();
}