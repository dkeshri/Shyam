﻿using Shyam.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.interfaces.Interfaces
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecastServiceModel> GetWeather();
    }
}
