using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shyam.Extensibility.interfaces.Base
{
    public abstract class AbstractDependencyResolver : IDependencyResolver
    {
        public void SetUp(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            OnSetUp(serviceCollection, configuration);
        }
        protected abstract void OnSetUp(IServiceCollection serviceCollection, IConfiguration configuration);
        protected void AddServiceDescriptors(IServiceCollection serviceCollection, string interfaceNameSpace)
        {
            var typesInAssembly = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes());
            var typesInAssemblyArray = typesInAssembly as Type[] ?? typesInAssembly.ToArray();

            var interfacesFound = typesInAssemblyArray.Where(selectedType => (selectedType != null) && (selectedType.IsInterface &&
                ((selectedType.Namespace != null) && selectedType.Namespace.Contains(interfaceNameSpace))));

            foreach (var interfaceFound in interfacesFound)
            {
                if (interfaceFound.IsGenericType)
                    continue;

                var interfaceImplementations = typesInAssemblyArray.Where(selectedType => !selectedType.IsInterface &&
                    !selectedType.IsAbstract &&
                    interfaceFound.IsAssignableFrom(selectedType));
                foreach (var interfaceImplementing in interfaceImplementations)
                {
                    serviceCollection.Add(new ServiceDescriptor(interfaceFound, interfaceImplementing, ServiceLifetime.Scoped));
                }

            }

        }
    }
}
