using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Eureka.Nancy.Service1.ExternalServices
{
    public class CityDataService : ICityDataService
    {
        private const string URL = "http://WeatherService/Temperatures/";
        private HttpClient _client;
        public CityDataService(HttpClient client)
        {
            _client = client;
        }
        public async Task<string> RandomFortuneAsync()
        {
            return await _client.GetStringAsync(URL);
        }
    }

    public interface ICityDataService
    {
    }
}
