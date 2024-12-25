using Shyam.Services.interfaces._Base;
using Shyam.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shyam.Services.Models._auth;

namespace Shyam.Services.Logic.Services._Auth
{
    public class AuthenticationService : ServiceBase, IAuthenticationService
    {
        private ITokenService TokenService { get; }

        public AuthenticationService(ITokenService tokenService)
        {
            TokenService = tokenService;
        }
        public AuthenticatedUser Login(UserCredientials authenticatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
