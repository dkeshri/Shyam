using AutoMapper;
using Microsoft.Extensions.Logging;
using Shyam.Services.interfaces._Base;
using Shyam.Services.interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Services.Logic.Services
{
    internal class DemoService : ServiceBase, IDemoService
    {
        public DemoService(ILogger<DemoService> logger, IMapper mapper):base(logger, mapper)
        {
            
        }
    }
}
