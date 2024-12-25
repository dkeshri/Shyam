using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shyam.Services.interfaces;
using Shyam.Services.interfaces.Interfaces;
using Shyam.Services.Models._auth;
using Shyam.WebApi.Controllers._base;

namespace Shyam.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ApiControllerBase<WeatherForecastController, IWeatherService>
    {
        

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IMapper mapper, IWeatherService weatherService) 
            : base(logger,mapper,weatherService) 
        {
           
        }

        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecastDto>> Get()
        {
            var weatherForecast = ControllerService.GetWeather();
            return Ok(Mapper.Map<IEnumerable<WeatherForecastDto>>(weatherForecast));
        }

        //[HttpGet("{weatherId:long}")]
        //public ActionResult<WeatherForecastDto> GetWatherById(long weatherId)
        //{

        //    //var customer = ControllerService.GetCustomer(customerId);
        //    //return Ok(Mapper.Map<CustomerDto>(customer));


        //}
    }
}
