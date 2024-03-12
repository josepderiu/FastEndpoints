namespace WebApi.Endpoints;

using FastEndpoints;

using WebApi.Contracts.Requests;
using WebApi.Contracts.Responses;

using WebApi.Services;

public class WeatherForecastByDaysEndpoint(IWeatherforecastService weatherforecastService) :
    Endpoint<WeatherforecastRequest, WeatherforecastResponse>
{
    private readonly IWeatherforecastService _weatherforecastService = weatherforecastService;

    public override void Configure()
    {
        Get("/weatherforecast/{days}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(WeatherforecastRequest req,
        CancellationToken ct)
    {
        var forecasts = _weatherforecastService.GetWeatherforecast(req.Days);

        var response = new WeatherforecastResponse(Days: forecasts.Length, Forecasts: forecasts);

        await SendAsync(response, cancellation: ct);
    }
}
