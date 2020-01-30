using BelfastWeatherApi.Common;
using BelfastWeatherApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi
{
    public static class ApiHelper
    {
        public static List<City> GetAllCities()
        {
            return Constants.Cities.AvailableCities.Select(p => new City(p.Key, p.Value)).ToList();
        }

        public static int GetCityIdByName(string cityName)
        {
            return Constants.Cities.AvailableCities[cityName];
        }
    }
}
