using Sistema.Proctor.Data.Dto;

namespace Sistema.Proctor.Data.Repositories;

public interface IResultadosEnsayoProctorRepository
{
    Task<List<ResultadosEnsayoProctorDto>> GetResultadosEnsayoProctor(int idensayoProctor);
}