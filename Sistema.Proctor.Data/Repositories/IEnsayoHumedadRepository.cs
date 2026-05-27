using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IEnsayoHumedadRepository : IRepository<EnsayoHumedad>
{
    
}

public class EnsayoHumedadRepository : Repository<EnsayoHumedad>,IEnsayoHumedadRepository
{
    public EnsayoHumedadRepository(DataContextProctor context) : base(context)
    {
    }
}