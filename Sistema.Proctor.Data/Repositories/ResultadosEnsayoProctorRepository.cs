using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Dto;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public class ResultadosEnsayoProctorRepository(DataContextProctor dataContextProctor) : IResultadosEnsayoProctorRepository
{
    public Task<List<ResultadosEnsayoProctorDto>> GetResultadosEnsayoProctor(int idensayoProctor)
    {
        var query = from r in dataContextProctor.EnsayoProctors.AsNoTracking()
            join rp in dataContextProctor.ResultadosProctors on r.Idensayo equals rp.Idensayo
            join m in dataContextProctor.Muestras on r.Idmuestra equals m.Idmuestra
            join p in dataContextProctor.Proyectos on m.Idproyecto equals p.Idproyecto
            join cl in dataContextProctor.Clientes on p.Idcliente equals cl.Idcliente
            join em in dataContextProctor.Empleados on m.Idempleado equals em.Idempleado 
            where r.Idensayo == idensayoProctor
            select new ResultadosEnsayoProctorDto(
                rp.AguaAgregada.Value,
                rp.PesoMoldeMaterialHumedo.Value, 
                rp.PesoMolde.Value,
                rp.PesoMaterialHumedo.Value,
                rp.VolumenMolde.Value, 
                rp.DensidadHumeda.Value, 
                rp.TaraNumero, 
                rp.TaraMaterialHumedo.Value,
                rp.TaraMaterialSeco.Value, 
                rp.PesoAgua.Value,
                rp.PesoTara.Value, 
                rp.PesoSueloSeco.Value,
                rp.ContenidoHumedad.Value, 
                rp.DensidadSeca.Value,
                r,
                m,
                p.Descripcion,
                cl.NombreComercial,
                $"{em.Nombre} {em.Apellido}");
        return query.ToListAsync();
    }
}