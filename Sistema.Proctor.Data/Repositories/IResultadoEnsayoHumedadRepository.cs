using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IResultadoEnsayoHumedadRepository : IRepository<ResultadoHumedad>
{
    Task<List<ResultadoEnsayoHumedadDto>> GetResultadosEnsayoHumedad(int idensayoHumedadId);
    Task DeleteWhereIdNotIn(int ensayoHumedadIdensayohumedad, IList<ResultadoHumedad> resultadosGrid);
}

public class ResultadoEnsayoHumedadRepository : Repository<ResultadoHumedad>, IResultadoEnsayoHumedadRepository
{
    private readonly DataContextProctor _dataContext;

    public ResultadoEnsayoHumedadRepository(DataContextProctor contextProctor) : base(contextProctor)
    {
        _dataContext = contextProctor;
    }

    public Task<List<ResultadoEnsayoHumedadDto>> GetResultadosEnsayoHumedad(int idensayoHumedadId)
    {
        var query = from reh in _dataContext.ResultadoHumedads.AsNoTracking()
            join eh in _dataContext.EnsayoHumedads on reh.Idensayohumedad equals eh.Idensayohumedad
            join m in _dataContext.Muestras on eh.Idmuestra equals m.Idmuestra
            join pr in _dataContext.Proyectos on m.Idproyecto equals pr.Idproyecto
            join cl in _dataContext.Clientes on pr.Idcliente equals cl.Idcliente
            join ensayado in _dataContext.Empleados on eh.EnsayadoPor equals ensayado.Idempleado
            join revisado in _dataContext.Empleados on eh.EnsayadoPor equals revisado.Idempleado
            join verificado in _dataContext.Empleados on eh.EnsayadoPor equals verificado.Idempleado
            join autorizado in _dataContext.Empleados on eh.EnsayadoPor equals autorizado.Idempleado
            where eh.Idensayohumedad == idensayoHumedadId
            select new ResultadoEnsayoHumedadDto(
                eh,
                reh,
                m,
                pr,
                cl,
                $"{ensayado.Nombre} {ensayado.Apellido}",
                $"{revisado.Nombre} {revisado.Apellido}",
                $"{verificado.Nombre} {verificado.Apellido}",
                $"{autorizado.Nombre} {autorizado.Apellido}"
            );
        return query.ToListAsync();
    }


    public Task DeleteWhereIdNotIn(int idEnsayoHumedad, IList<ResultadoHumedad> resultadosGrid)
    {
        return Task.Run(() =>
        {
            var ids = resultadosGrid.Select(humedad => humedad.Idresultadohumedad);
            _dataContext.ResultadoHumedads.RemoveRange(
                _dataContext.ResultadoHumedads
                    .Where(x =>
                        x.Idensayohumedad == idEnsayoHumedad &&
                        !ids.Contains(x.Idresultadohumedad)
                    )
            );
        });
    }
}