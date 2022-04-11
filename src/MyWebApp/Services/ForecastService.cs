using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using MyWebApp.Models;
using System.Text.Json;

namespace MyWebApp.Services
{
    public class ForecastService 
    {
        string IDOWeather = "42893b1535cabe5a359b4057bb9d53f9";
        public async Task<WeatherResponse> GetForecast(string latitude, string longitude, string units)
        {
            string unitsSelected = units=="2" ? "imperial" : "metric";
            // Connection String
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&units={unitsSelected}&APPID={IDOWeather}");
            
            var request = new RestRequest();
            var response = await client.GetAsync<WeatherResponse>(request);

            return response;
        }
        public async Task<WeatherResponse2> GetForecast2(string latitude, string longitude)
        {
            // Connection String
            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&APPID={IDOWeather}");
            
            var request = new RestRequest();
            var response = await client.GetAsync<WeatherResponse2>(request);

            return response;
        }
    }
}