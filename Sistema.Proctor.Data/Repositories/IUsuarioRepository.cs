using Microsoft.EntityFrameworkCore;
using Sistema.Proctor.Data.Entities;

namespace Sistema.Proctor.Data.Repositories;

public interface IUsuarioRepository : IRepository<Usuario>
{
    Task<Usuario?> GetByUsernameAsync(string username);
}

public class UsuarioRepository : Repository<Usuario>,IUsuarioRepository
{
    private readonly DataContextProctor _context;
    public UsuarioRepository(DataContextProctor context) : base(context)
    {
        _context = context;
    }

    public Task<Usuario?> GetByUsernameAsync(string username)
    {
        return _context.Usuarios.AsNoTracking().SingleOrDefaultAsync(usuario => usuario.Username == username);
    }
}