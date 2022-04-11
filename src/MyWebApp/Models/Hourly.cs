using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class Hourly
    {
        public int Dt { get; set; }
        public float Temp { get; set; }
        public float FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float DewPoint { get; set; }
        public float Uvi { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public float WindSpeed { get; set; }
        public int WindDeg { get; set; }
        public int WindGust { get; set; }
        public List<Weather> Weather { get; set; }
        public float Pop { get; set; }
    }
}