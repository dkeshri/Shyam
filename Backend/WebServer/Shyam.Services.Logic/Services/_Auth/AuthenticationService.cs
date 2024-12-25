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
using Shyam.Data.Entities;

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
        public AuthenticatedUser Login(UserCredientials userCredientials)
        {
            try
            {
                User user = UserRepository.GetByUserName(userCredientials.UserName, userCredientials.Password);
                    
                if (user != null)
                {
                    UserModel userModel = Mapper.Map<UserModel>(user);
                    return GetAuthenticatedUser(userModel);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                
                Logger.LogError(ex, "User Not Found");
                throw new Exception("User Not Found");
            }

            
        }

        private AuthenticatedUser GetAuthenticatedUser(UserModel userModel)
        {
            string token = TokenService.CreateToken(userModel);
            AuthenticatedUser authenticatedUser = new AuthenticatedUser()
            {
                UserName = userModel.Username,
                Token = token
            };
            return authenticatedUser;
        }
    }
}
