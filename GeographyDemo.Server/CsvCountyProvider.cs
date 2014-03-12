using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Server
{
    public class CsvCountyProvider : ICountyProvider
    {
        public CountyData[] GetCounties()
        {
            using(var streamReader = new StreamReader("Counties.csv", Encoding.ASCII))
            {
                var counties = new List<CountyData>();
                string countyName;
                while((countyName = streamReader.ReadLine()) != null)
                {
                    var county = new CountyData { Name = countyName };
                    counties.Add(county);
                }
                return counties.ToArray();
            }
        }
    }
}
