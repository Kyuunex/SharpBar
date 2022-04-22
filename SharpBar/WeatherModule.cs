using System;
using System.Net;

namespace SharpBar;

public class WeatherModule
{
    private const string WeatherAPI = "https://wttr.in/?format=2";

    private string weather_contents;

    public WeatherModule()
    {
        weather_contents = new WebClient().DownloadString(WeatherAPI);
    }
    
    public Module GetBlock()
    {
        var weatherblock = new Module
        {
            name = "weather",
            full_text = weather_contents
        };
        
        return weatherblock;
    }
}