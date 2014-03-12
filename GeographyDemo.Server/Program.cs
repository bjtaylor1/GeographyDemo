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
            using(ServiceHost serviceHost = new ServiceHost(typeof(CountiesService)))
            {
                serviceHost.Open();
                Console.WriteLine("Service running");
                Console.Read();
            }
        }
    }
}
