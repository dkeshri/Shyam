using AutoMapper;
using Shyam.Services.Models;
using Shyam.Services.Models._auth;
using Shyam.WebApi.Dtos;

namespace Shyam.WebApi.Profiles
{
    public class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<WeatherForecastDto, WeatherForecastServiceModel>().ReverseMap();
        }
    }
}
