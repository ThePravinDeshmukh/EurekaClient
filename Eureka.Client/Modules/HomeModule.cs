using Nancy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Nancy.API.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("Home")
        {

            Get("/", (parameters, token) =>
            {
                return Task.FromResult<dynamic>("Hello from some service!");
            });
        }
    }
}
