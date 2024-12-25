using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Extensibility.interfaces
{
    public interface IDependencyResolver
    {
        void SetUp(IServiceCollection serviceCollection, IConfiguration configuration);
    }
}
