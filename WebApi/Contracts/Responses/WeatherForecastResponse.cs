using WebApi.Models;

namespace WebApi.Contracts.Responses;

public sealed record WeatherforecastResponse(int Days, IEnumerable<WeatherForecast> Forecasts)
{
    public int Days { get; init; } = Days;

    public IEnumerable<WeatherForecast> Forecasts { get; init; } = Forecasts;
}