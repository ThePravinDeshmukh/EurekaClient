using Steeltoe.Common.Discovery;
using Steeltoe.Discovery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eureka.Nancy.Service1.ExternalServices
{
    public class DiscoveryClient //: IDiscoveryClient
    {
        public string Description => throw new NotImplementedException();

        public IList<string> Services => throw new NotImplementedException();

        public IList<IServiceInstance> GetInstances(string serviceId)
        {
            throw new NotImplementedException();
        }

        public IServiceInstance GetLocalServiceInstance()
        {
            throw new NotImplementedException();
        }

        public Task ShutdownAsync()
        {
            throw new NotImplementedException();
        }
    }
}
