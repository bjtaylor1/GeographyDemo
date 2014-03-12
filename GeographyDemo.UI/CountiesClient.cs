using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GeographyDemo.Contracts;
using System.Threading;

namespace GeographyDemo.UI
{
    public class CountiesClient : ClientBase<ICountiesService>, ICountyProvider, IAsyncCountyProvider
    {
        public CountyData[] GetCounties()
        {
            Thread.Sleep(2000);
            return Channel.GetCounties();
        }

        public Task<CountyData[]> GetCountiesAsync()
        {
            return Task.Run(() => GetCounties());
        }
    }
}
