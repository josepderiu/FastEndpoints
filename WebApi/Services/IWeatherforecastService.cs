namespace WebApi.Services;

using WebApi.Models;

public interface IWeatherforecastService
{
    WeatherForecast[] GetWeatherforecast(int days = 5);
}