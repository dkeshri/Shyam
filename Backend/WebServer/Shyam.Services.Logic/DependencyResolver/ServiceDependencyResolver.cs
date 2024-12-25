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

namespace Shyam.Services.Logic.DependencyResolver
{
    [Export(typeof(IDependencyResolver))]
    public class ServiceDependencyResolver : AbstractDependencyResolver
    {
        protected override void OnSetUp(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //serviceCollection.AddAutoMapper(cfg =>
            //{
            //    cfg.AllowNullCollections = true;
            //}, typeof(ServiceDependencyResolver));
            AddServiceDescriptors(serviceCollection, "Shyam.Services.interfaces");
        }
    }
}
