using Eureka.Nancy.Service2.Modules;
using Microsoft.Extensions.Configuration;
using Nancy;
using Nancy.Json;
using Newtonsoft.Json;
using Steeltoe.Common.Discovery;
using Steeltoe.Discovery;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Nancy.Service1.Modules
{
    public class WeatherReportModule : NancyModule
    {
        private readonly DiscoveryHttpClientHandler _handler;
        public WeatherReportModule(IDiscoveryClient discoveryClient) : base("WeatherReport")
        //public WeatherReportModule() : base("WeatherReport")
        {
            //_handler = new DiscoveryHttpClientHandler(discoveryClient);

            Get("/{city}", (parameters, token) =>
            {
                return Task.FromResult<dynamic>(GetWeatherData(parameters.city));
            });
        }

        private async Task<List<WeatherData>> GetWeatherData(string city)
        {
            //var client = new HttpClient(_handler, false);
            var client = new HttpClient();
            var result = await client.GetAsync($"http://WeatherService/Temperatures/{city}");

            return JsonConvert.DeserializeObject<List<WeatherData>>(result.Content.ToString());
        }
    }
}
