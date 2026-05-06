using Proyecto2025_III.Shared.DTO;
using Proyecto2025_III.Shared.ENUM;

namespace Proyecto2025_III.Servicio.Seguridad;

public class ServicioSeguridad : IServicioSeguridad
{
    private readonly AppDbContext _context;

    public ServicioSeguridad(AppDomain
    {
        
    }
    public Task<ResultadoOperacionSeguridad> HacerAdmin(string email)
    {
        throw new NotImplementedException();
    }

    public Task<List<UsuarioDTO>> ObtenerUsuarios(string email)
    {
        throw new NotImplementedException();
    }

    public Task<ResultadoOperacionSeguridad> RemoverAdmin(string email)
    {
        throw new NotImplementedException();
    }
}
