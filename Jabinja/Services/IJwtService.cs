using Jabinja.Entity;

namespace Jabinja.Services
{
    public interface IJwtService
    {
        public string GetJwtToken(User user);
    }
}
