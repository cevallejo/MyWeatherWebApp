using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Services;
using System.Net;
using System;
using MyWebApp.Models;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public ForecastService forecastService;
    public WeatherResponse weatherResponse;
    public WeatherResponse2 weatherResponse2;
    public String windSpeed;
    public string latitude, longitude,units;
    public int day;
    
    public IndexModel(ILogger<IndexModel> logger, ForecastService forecastService)
    {
        _logger = logger;
        this.forecastService = forecastService;
    }

    public void OnGet(int day = 0)
    {
        latitude = Request.Cookies["latitude"];
        longitude = Request.Cookies["longitude"];
        units = Request.Cookies["units"];

        if(latitude!=null && latitude!="") {
            weatherResponse = forecastService.GetForecast(latitude,longitude,units).Result;
            weatherResponse2 = forecastService.GetForecast2(latitude,longitude).Result;
            windSpeed = (weatherResponse.Current.Wind_Speed*3.6).ToString("F");//(3600/1000 to convert met/sec to km/h)
        }

        this.day = day;
    }

}
