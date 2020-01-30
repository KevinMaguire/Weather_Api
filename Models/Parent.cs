using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Models
{
    public partial class Parent
    {
        public string Title { get; set; }
        public string LocationType { get; set; }
        public long Woeid { get; set; }
        public string LattLong { get; set; }
    }

}
