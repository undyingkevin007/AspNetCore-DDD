using System.Security.Claims;
using System.Threading.Tasks;

namespace DDD.Infra.CrossCutting.Identity.Services
{
    public interface IJwtFactory
    {
        Task<string> GenerateJwtToken(string email, ClaimsIdentity claimsIdentity);
    }
}
