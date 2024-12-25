using Shyam.Services.interfaces._Base;
using Shyam.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shyam.Services.Models._auth;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Shyam.Data.Interfaces.Repositories;

namespace Shyam.Services.Logic.Services._Auth
{
    internal class AuthenticationService : ServiceBase, IAuthenticationService
    {
        private ITokenService TokenService { get; }
        private IUserRepository UserRepository { get; }

        public AuthenticationService(ILogger<AuthenticationService> logger, IMapper mapper,
            ITokenService tokenService,IUserRepository userRepository):base(logger,mapper)
        {
            TokenService = tokenService;
            UserRepository = userRepository;
        }
        public AuthenticatedUser Login(UserCredientials authenticatedUser)
        {
            UserRepository.AllUser();
            throw new NotImplementedException();
        }
    }
}
