using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IEnsayoRepository:IRepository<Ensayo>
{
    public Task<List<EnsayoRecordDto>> GetEnsayosByMuestra(int idMuestra);
}

public class EnsayoRepository : Repository<Ensayo>,IEnsayoRepository
{

    private DataContextProctor _dataContext;
    public EnsayoRepository(DataContextProctor context) : base(context)
    {
        _dataContext = context;
    }

    public Task<List<EnsayoRecordDto>> GetEnsayosByMuestra(int idMuestra)
    {
        return _context.Ensayos.AsNoTracking().Where(ensayo => ensayo.Idmuestra == idMuestra)
            .Join(_dataContext.TipoEnsayos, ensayo => ensayo.Idtipoensayo, ensayo => ensayo.Idtipoensayo,
                (ensayo, tipoEnsayo) => tipoEnsayo)
            .Select(ensayo => new EnsayoRecordDto(idMuestra,ensayo.Idtipoensayo, ensayo.Descripcion)).ToListAsync();
    }
}