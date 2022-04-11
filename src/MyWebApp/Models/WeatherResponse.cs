using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class WeatherResponse
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public String Timezone { get; set; }
        public int TimezoneOffset { get; set; }
        public Current Current { get; set; }
        public List<Minutely> Minutely { get; set; }
        public List<Hourly> Hourly { get; set; }
        public List<Daily> Daily { get; set; }

    }
}