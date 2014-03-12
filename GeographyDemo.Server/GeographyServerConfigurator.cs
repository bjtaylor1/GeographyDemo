using Autofac;
using Autofac.Core;
using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Server
{
    class GeographyServerConfigurator 
    {
        public static IContainer ConfigureAndCreateDependencyContainer()
        {
            var containerBuilder = new ContainerBuilder();
            
            //for now, we're using the CSV provider as our database.
            containerBuilder.RegisterType<CsvCountyProvider>().As<ICountyProvider>();
            //register the service
            containerBuilder.RegisterType<CountiesService>().AsImplementedInterfaces();

            return containerBuilder.Build();
        }
    }
}
