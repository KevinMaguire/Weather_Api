using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Models
{
    public partial class ConsolidatedWeather
    {
        public long Id { get; set; }
        public string Weather_State_Name { get; set; }
        public string Weather_State_Abbr { get; set; }
        public string Wind_Direction_Compass { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Applicable_Date { get; set; }
        public double Min_Temp { get; set; }
        public double Max_Temp { get; set; }
        public double The_Temp { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Direction { get; set; }
        public double Air_Pressure { get; set; }
        public long Humidity { get; set; }
        public double Visibility { get; set; }
        public long Predictability { get; set; }
        public string ImageUrl => $"https://www.metaweather.com/static/img/weather/{Weather_State_Abbr}.svg";
    }
}
