using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using GeographyDemo.Contracts;

namespace GeographyDemo.UI
{
    public class CountiesClient : ClientBase<ICountiesService>, ICountyProvider
    {
        public CountyData[] GetCounties()
        {
            return Channel.GetCounties();
        }
    }
}
