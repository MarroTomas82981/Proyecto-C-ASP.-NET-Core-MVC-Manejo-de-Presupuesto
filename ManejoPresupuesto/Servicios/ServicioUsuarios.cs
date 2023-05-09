using DocumentFormat.OpenXml.Spreadsheet;
using System.Security.Claims;

namespace ManejoPresupuesto.Servicios
{
    public interface IServicioUsuarios
    {
        int ObtenerUsuarioId();
    }

    public class ServicioUsuarios : IServicioUsuarios
    {
        private readonly HttpContext httpContext;

        public ServicioUsuarios(IHttpContextAccessor httpContextAccessor)
        {
            httpContext = httpContextAccessor.HttpContext;
        }


        public int ObtenerUsuarioId()
        {

            if (httpContext.User.Identity.IsAuthenticated)
            {
                var idclaims= httpContext.User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier)
                    .FirstOrDefault();
                var id = int.Parse(idclaims.Value);
                return id;
            }
            else
            {
                throw new ApplicationException("El usuario no está autenticado");
            }
        }
    }
}
