using Proyecto2025_III.Shared.DTO;
using Proyecto2025_III.Shared.ENUM;

namespace Proyecto2025_III.Servicio.Seguridad;

public class ServicioSeguridad : IServicioSeguridad
{

    //public ServicioSeguridad(AppDbContext<ApplicationUser> context,
    //                         UserManager<ApplicationUser> userManager, 
    //                         IHttpContextAccessor httpContextAccessor, 
    //                         IAuthorizationService authorizationService
    //{
        
    //}
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
