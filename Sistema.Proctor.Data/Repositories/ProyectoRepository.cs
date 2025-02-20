using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public class ProyectoRepository : Repository<Proyecto>, IProyectoRepository
{
    private readonly DataContextProctor _DataContextProctor;

    public ProyectoRepository(DataContextProctor dataContextProctor) : base(dataContextProctor)
    {
        _DataContextProctor = dataContextProctor;
    }

    public Task<List<Proyecto>> FindByDateList()
    {
        return _DataContextProctor.Proyectos
            .AsNoTracking()
            .Include(proyecto => proyecto.Cliente)
            .AsNoTracking()
            .Where(proyecto => proyecto.Activo)
            .ToListAsync();
    }
}