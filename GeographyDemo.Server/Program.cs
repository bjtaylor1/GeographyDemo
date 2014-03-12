using Autofac;
using Autofac.Core;
using Autofac.Integration.Wcf;
using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the DI container:
            var container = GeographyServerConfigurator.ConfigureAndCreateDependencyContainer();

            using(ServiceHost serviceHost = new ServiceHost(typeof(CountiesService)))
            {
                serviceHost.AddDependencyInjectionBehavior<ICountiesService>(container);
                serviceHost.Open();
                Console.WriteLine("Service running");
                Console.Read();
            }
        }
    }
}
