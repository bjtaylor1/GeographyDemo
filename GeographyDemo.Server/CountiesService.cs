using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Server
{
    public class CountiesService : ICountiesService
    {
        private readonly ICountyProvider countyProvider;

        public CountiesService(ICountyProvider countyProvider)
        {
            this.countyProvider = countyProvider;
        }

        public CountyData[] GetCounties()
        {
            Console.WriteLine("GetCounties called");

            //at the moment, for simplicity, the service is returning the same data type 
            //the provider returns.
            //but it could transform it into a more service-oriented entity that is not
            //polluted with database attributes, etc. Possibly using AutoMapper.
            return countyProvider.GetCounties();
        }
    }
}
