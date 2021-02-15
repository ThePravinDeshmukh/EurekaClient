using Nancy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Nancy.Service2.Modules
{
    public class HealthModule : NancyModule
    {
        public HealthModule() : base("Health")
        {

            Get("/", (parameters, token) =>
            {
                return Task.FromResult<dynamic>("I'm alive!");
            });
        }
    }
}
