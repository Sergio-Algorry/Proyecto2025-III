using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Proyecto2025_III.BD.Datos;
using Proyecto2025_III.Shared.DTO;
using Proyecto2025_III.Shared.ENUM;

namespace Proyecto2025_III.Repositorio.Seguridad;

public class ServicioSeguridad : IServicioSeguridad
{
    private readonly AppDbContext context;
    private readonly UserManager<ApplicationUser> userManager;
    private readonly IHttpContextAccessor contextAccesor;
    private readonly IAuthorizationService authorizationService;

    public ServicioSeguridad(AppDbContext context,
                             UserManager<ApplicationUser> userManager,
                             IHttpContextAccessor contextAccesor,
                             IAuthorizationService authorizationService)
    {
        this.context = context;
        this.userManager = userManager;
        this.contextAccesor = contextAccesor;
        this.authorizationService = authorizationService;
    }

    public async Task<ResultadoOperacionSeguridad> HacerAdmin(string email)
    {
        try
        {
            var usuarioLogueado = contextAccesor.HttpContext.User;
            var resultado = await authorizationService.AuthorizeAsync(usuarioLogueado, "EsAdmin");

            if (!resultado.Succeeded)
            {
                return ResultadoOperacionSeguridad.SinPermiso;
            }
            var usuario = await userManager.FindByEmailAsync(email);

            if (usuario == null)
            {
                return ResultadoOperacionSeguridad.NoEncontrado;
            }

            await userManager.AddToRoleAsync(usuario, "admin");
            await userManager.UpdateSecurityStampAsync(usuario);

            return ResultadoOperacionSeguridad.Exitoso;
        }
        catch (Exception e)
        {
            return ResultadoOperacionSeguridad.Fallido;
        }
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
