using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Portfolio.Tests;

public class ApiSmokeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ApiSmokeTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task WeatherForecastEndpoint_IsNotMapped()
    {
        var response = await _client.GetAsync("/WeatherForecast");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task HealthEndpoint_IsNotMapped()
    {
        var response = await _client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}