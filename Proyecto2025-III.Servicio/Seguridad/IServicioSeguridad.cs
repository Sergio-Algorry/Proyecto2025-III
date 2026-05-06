using Proyecto2025_III.Shared.DTO;
using Proyecto2025_III.Shared.ENUM;

namespace Proyecto2025_III.Servicio.Seguridad;

public interface IServicioSeguridad
{
    Task<ResultadoOperacionSeguridad> HacerAdmin (string email);
    Task<ResultadoOperacionSeguridad> RemoverAdmin(string email);
    Task<List<UsuarioDTO>> ObtenerUsuarios(string email);
}
