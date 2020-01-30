using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Models
{
    public partial class WeatherResult
    {
        public List<ConsolidatedWeather> Consolidated_Weather { get; set; }

        public string Time { get; set; }

        public string Sun_Rise { get; set; }

        public string Sun_Set { get; set; }

        public string Timezone_Name { get; set; }

        public Parent Parent { get; set; }

        public List<Source> Sources { get; set; }

        public string Title { get; set; }

        public string Location_Type { get; set; }

        public int Woeid { get; set; }

        public string Latt_Long { get; set; }

        public string Timezone { get; set; }
    }
}
