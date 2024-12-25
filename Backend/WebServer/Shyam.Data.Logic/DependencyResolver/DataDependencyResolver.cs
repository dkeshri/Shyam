using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shyam.Extensibility.interfaces;
using Shyam.Extensibility.interfaces.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Data.Logic.DependencyResolver
{
    [Export(typeof(IDependencyResolver))]
    public class DataDependencyResolver : AbstractDependencyResolver
    {
        protected override void OnSetUp(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //AddServiceDescriptors(serviceCollection, "Shyam.Data.Interfaces.DataContext");
            //AddServiceDescriptors(serviceCollection, "Shyam.Data.Interfaces.Providers");
            AddServiceDescriptors(serviceCollection, "Shyam.Data.Interfaces.Repositories");

            //AddServiceDescriptors(serviceCollection, "Shyam.Data.Interfaces.UnitOfWork");
        }
    }
}
