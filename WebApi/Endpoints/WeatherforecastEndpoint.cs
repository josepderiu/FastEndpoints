namespace WebApi.Endpoints;

using FastEndpoints;

using WebApi.Contracts.Responses;

using WebApi.Services;

public class WeatherforecastEndpoint(IWeatherforecastService weatherforecastService) :
    EndpointWithoutRequest<WeatherforecastResponse>
{
    private readonly IWeatherforecastService _weatherforecastService = weatherforecastService;

    public override void Configure()
    {
        Get("/weatherforecast");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var forecasts = _weatherforecastService.GetWeatherforecast();

        var response = new WeatherforecastResponse(Days: forecasts.Length, Forecasts: forecasts);

        await SendAsync(response, cancellation: ct);
    }
}