using Shyam.Services.Models._auth;

namespace Shyam.Services.interfaces
{
    public interface IAuthenticationService
    {
        public AuthenticatedUser Login(UserCredientials userCredientials);
    }
}
