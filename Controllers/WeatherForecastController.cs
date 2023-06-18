using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelfastWeatherApi.HttpClient;
using BelfastWeatherApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace BelfastWeatherApi.Controllers
{ 
    // Added this purposely as I cant get the Azure AD B2C / Identity integration working yet :( 
    // Another option is auth0 and use universal login and avail of the ready made customizable login interface ( if i cant get this going soon :) )

    [AllowAnonymous] 
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRestSharpHttpClient _restsharpclient;

        public WeatherForecastController(IRestSharpHttpClient restsharpclient)
        {
            _restsharpclient = restsharpclient;
        }

        [HttpGet("GetAllCities")]
        public IActionResult Get()
        {
            // Test only
            return Ok(JsonConvert.SerializeObject(ApiHelper.GetAllCities()));
        }

        [HttpGet("GetByName")]
        public IActionResult Get(string cityname)
        {
            var cityId = ApiHelper.GetCityIdByName(cityname);
            var response = _restsharpclient.ExecuteGet($"location/{cityId}");

            var serializedResult = JsonConvert.DeserializeObject<WeatherResult>(response.Content);
           
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok(serializedResult);

            return NotFound(); 
        }

        [HttpGet("SummerFeature_All_Users")]
        public IActionResult GetAll()
        {
            return Ok("GlobalFeatureUpdate");
        }
    }
}
