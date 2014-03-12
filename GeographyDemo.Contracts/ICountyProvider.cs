using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Contracts
{
    public interface ICountyProvider
    {
        CountyData[] GetCounties();
    }
}
