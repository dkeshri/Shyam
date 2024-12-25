using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shyam.Services.interfaces;
using Shyam.Services.Models._auth;
using Shyam.WebApi.Dtos;

namespace Shyam.WebApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private ILogger<AuthenticationController> Logger { get; }
        private IMapper Mapper { get; }
        private IAuthenticationService AuthenticationService { get; }
        public AuthenticationController(ILogger<AuthenticationController> logger, IMapper mapper, IAuthenticationService authenticationService)
        {
            Logger = logger;
            Mapper = mapper;
            AuthenticationService = authenticationService;

        }
        [Route("Login")]
        [HttpPost]
        public ActionResult<AuthenticatedUser> Login(UserCredientialsDto userCredientialsDto)
        {

            AuthenticatedUser AuthenticatedUser = AuthenticationService.Login(Mapper.Map<UserCredientials>(userCredientialsDto));
            if (AuthenticatedUser == null)
            {
                Logger.LogInformation($"Invalid UserName: {userCredientialsDto.UserName} and Password: {userCredientialsDto.Password} ");
                return Unauthorized();
            }

            return Ok(AuthenticatedUser);
        }
    }
}
