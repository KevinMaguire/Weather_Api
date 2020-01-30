using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Models
{
    public class City
    {
        public City(string city, int woeid)
        {
            CityName = city;
            Woeid = woeid;
        }

        public string CityName { get; set; }

        public int Woeid { get; set; }
    }
}
