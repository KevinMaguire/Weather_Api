using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.HttpClient
{
    // Note - No ASYNC available to preserve server resources & memory - I would normally use 
    // async processing.Eg: roll my own httpClient and use async where possible via tasks
    // Restsharp client though is good enough here for this example.

    public class RestSharpHttpClient : IRestSharpHttpClient
    {
        private readonly IConfiguration _configuration;

        public RestSharpHttpClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IRestResponse ExecuteGet(string actionMethod)
        {
            var baseUri = _configuration.GetSection("WeatherApi").GetSection("UriByLocation").Value;
            var client = new RestClient(baseUri);
            var request = new RestRequest($"/api/{actionMethod}", Method.GET);

            return client.Execute(request);
        }
    }
}
