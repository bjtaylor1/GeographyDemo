using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.UI
{
    public interface IAsyncCountyProvider
    {
        Task<CountyData[]> GetCountiesAsync();
    }
}
