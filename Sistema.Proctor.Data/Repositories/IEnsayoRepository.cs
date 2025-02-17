using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IEnsayoRepository:IRepository<Ensayo>
{
    public Task<List<EnsayoRecordDto>> GetEnsayosByMuestra(int idMuestra);
}