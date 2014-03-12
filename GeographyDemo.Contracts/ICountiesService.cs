using GeographyDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeographyDemo.Contracts
{
    [ServiceContract]
    public interface ICountiesService
    {
        [OperationContract]
        CountyData[] GetCounties();
    }
}
