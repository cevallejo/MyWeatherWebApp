using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public class Current
    {
        public int Dt { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public float Temp { get; set; }
        public float FeelsLike { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float DewPoint { get; set; }
        public float Uvi { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public float Wind_Speed { get; set; }
        public int Wind_Deg { get; set; }
        public float Wind_Gust { get; set; }
        public List<Weather> Weather { get; set; }
    }
}