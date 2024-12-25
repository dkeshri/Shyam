using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shyam.Extensibility.interfaces;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Reflection;

namespace Shyam.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            
        }

        public static void AddServiceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            LoadDependencies(services, configuration, "Shyam.Services.Logic.dll");
        }

        private static void LoadDependencies(IServiceCollection serviceCollection, IConfiguration configuration, string dependencyAssembly)
        {
            var codeBase = Assembly.GetExecutingAssembly().Location;
            if (!string.IsNullOrEmpty(codeBase))
            {
                var currentAssemblyPath = Path.GetDirectoryName(new Uri(codeBase).LocalPath);
                LoadDependencies(serviceCollection, configuration, currentAssemblyPath, dependencyAssembly);
            }
        }

        private static void LoadDependencies(IServiceCollection serviceCollection, IConfiguration configuration, string path, string dependancyAssemblyFileName)
        {
            var directoryCatalog = new DirectoryCatalog(path, dependancyAssemblyFileName);
            
            var importDef = new ImportDefinition(
                                def => true,
                                typeof(IDependencyResolver).FullName,
                                ImportCardinality.ZeroOrMore,
                                false,
                                false
                );
            try
            {
                using var aggregateCatalog = new AggregateCatalog();
                aggregateCatalog.Catalogs.Add(directoryCatalog);
                using var compositionContainer = new CompositionContainer(aggregateCatalog);
                IEnumerable<Export> exports = compositionContainer.GetExports(importDef);
                IEnumerable<IDependencyResolver> modules =
                    exports.Select(export => export.Value as IDependencyResolver).Where(m => m != null);
                foreach (IDependencyResolver module in modules)
                {
                    module.SetUp(serviceCollection, configuration);
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
