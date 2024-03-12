using FastEndpoints;
using FastEndpoints.Swagger;

using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IWeatherforecastService, WeatherforecastService>();

builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = builder.Configuration.GetValue<int>("HttpsPort");
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddFastEndpoints()
    .SwaggerDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseFastEndpoints();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerGen();
}

app.Run();