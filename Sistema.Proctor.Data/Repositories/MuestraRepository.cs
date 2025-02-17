using System.Threading.Tasks.Dataflow;
using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public class MuestraRepository : Repository<Muestra>, IMuestraRepository
{
    private readonly DataContextProctor _dataContext;

    public MuestraRepository(DataContextProctor context) : base(context)
    {
        _dataContext = context;
    }

    public Task<List<Muestra>> GetMuestraByProyecto(int idProyecto)
    {
        return _dataContext.Muestras.AsNoTracking().Where(muestra => muestra.Idproyecto==idProyecto)
            .Include(muestra => muestra.Ensayos)
            .ToListAsync();
    }

    public async Task AddMuestraTask(Muestra muestra)
    {
        await _dataContext.AddAsync(muestra);
    }
}