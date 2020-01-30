using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelfastWeatherApi.Models
{
    public partial class Source
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public Uri Url { get; set; }
        public long CrawlRate { get; set; }
    }
}
