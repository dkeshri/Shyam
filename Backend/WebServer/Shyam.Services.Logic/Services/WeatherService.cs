using AutoMapper;
using Microsoft.Extensions.Logging;
using Shyam.Services.interfaces._Base;
using Shyam.Services.interfaces.Interfaces;
using Shyam.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Services
{
    internal class WeatherService : ServiceBase, IWeatherService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherService(ILogger<WeatherService> logger, IMapper mapper):base(logger, mapper)
        {
            
        }


        public IEnumerable<WeatherForecastServiceModel> GetWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastServiceModel
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }
    }
}
