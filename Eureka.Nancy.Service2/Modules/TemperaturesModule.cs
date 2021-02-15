using Nancy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Nancy.Service2.Modules
{
    public class TemperaturesModule : NancyModule
    {
        public TemperaturesModule() : base("Temperatures")
        {

            Get("/", (parameters, token) =>
            {
                return Task.FromResult<dynamic>(
                    new List<WeatherData> {
                    new WeatherData("Mumbai", 28),
                    new WeatherData("Delhi", 26),
                    new WeatherData("Chennai", 32)
                }); ;
            });
        }
    }

    public class WeatherData
    {
        public WeatherData(string City, int Temperature)
        {
            this.City = City;
            this.Temperature = Temperature;
        }
        public string City { get; set; }
        public int Temperature { get; set; }
    }
}
