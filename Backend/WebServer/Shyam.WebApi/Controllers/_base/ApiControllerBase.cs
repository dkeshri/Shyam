using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Shyam.WebApi.Controllers._base
{
    [Authorize]
    [ApiController]
    public class ApiControllerBase<TController, TService> : ControllerBase
    {
        protected readonly TService ControllerService;
        protected readonly ILogger<TController> Logger;
        protected readonly IMapper Mapper;

        public ApiControllerBase(ILogger<TController> logger, IMapper mapper, TService service)
        {
            Logger = logger;
            Mapper = mapper;
            ControllerService = service;
        }
    }
}
