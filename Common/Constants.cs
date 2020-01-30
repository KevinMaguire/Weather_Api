using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Common
{
    public static class Constants
    {
        public static class Cities
        {
            // These values would normally be read in from a database, json file or some other source which is decoupled from
            // the code base - entered here for quick ease of use
            public static Dictionary<string, int> AvailableCities => new Dictionary<string, int>() { { "belfast", 44544 }, { "dublin", 560743 } };
        }

        public static class ActionMethods
        {
            public const string GetAllCities = "GetAllCities";
            public const string GetByName = "GetByName";
        }
    }
}
