# Learning Project - FastEndpoints Web API

This is a learning project aimed at understanding and implementing a Web API using the FastEndpoints library in .NET 8.0.

## Project Structure

The project is structured into several folders:

- `Contracts`: Contains the request and response models used by the API endpoints.
- `Models`: Contains internal data representation
- `Endpoints`: Contains the implementation of the API endpoints.
- `Services`: Contains the business logic used by the endpoints.

## HTTPS Port Configuration

The HTTPS port for this project is configured in the `appsettings.json` (or `appsettings.<Environment>.json` for specific environments) under the key `HttpsPort`.

For example:

```json
{
  "HttpsPort": 7089
}
```

## Running the Project

To run the project, use the following command in the terminal:

```sh
dotnet run --project WebApi/WebApi.csproj --launch-profile https
```
