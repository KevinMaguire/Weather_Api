using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.HttpClient
{
    public interface IRestSharpHttpClient
    {
        IRestResponse ExecuteGet(string actionMethod);
    }
}
