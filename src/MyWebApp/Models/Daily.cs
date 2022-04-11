using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class Daily
    {
        public int Dt { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public int Moonrise { get; set; }
        public int Moonset { get; set; }
        public float MoonPhase { get; set; }
        public Temp Temp { get; set; }
        public FeelsLike FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float DewPoint { get; set; }
        public float Wind_Speed { get; set; }
        public int WindDeg { get; set; }
        public int WindGust { get; set; }
        public List<Weather> Weather { get; set; }
        public int Clouds { get; set; }
        public float Pop { get; set; }
        public float Rain { get; set; }
        public float Uvi { get; set; }
    }
}