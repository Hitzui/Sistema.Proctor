using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IEmpresaRepository : IRepository<Empresa>
{
    Task<List<Empresa>> GetListByActiva();
}

public class EmpresaRepository : Repository<Empresa>,IEmpresaRepository
{
    private readonly DataContextProctor _contextProctor;
    public EmpresaRepository(DataContextProctor context) : base(context)
    {
        _contextProctor = context;
    }

    public Task<List<Empresa>> GetListByActiva()
    {
        return _contextProctor.Empresas.AsNoTracking().Where(empresa => empresa.Activa != null && empresa.Activa.Value).ToListAsync();
    }
}