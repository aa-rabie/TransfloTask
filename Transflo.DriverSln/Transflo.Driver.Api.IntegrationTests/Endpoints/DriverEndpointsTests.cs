using Mapster;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Data;
using Transflo.Driver.Models;
using Transflo.DriverApi;

namespace Transflo.Driver.Api.IntegrationTests.Endpoints
{
    public class DriverEndpointsTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;
        private readonly HttpClient _httpClient;

        public DriverEndpointsTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _httpClient = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task PostDriverWithValidParameters_ShouldSucceed()
        {

            var testDriver = DataSeedGenerator.GenerateDriverData(1, 1, false)[0].Adapt<DriverDto>();

            var response = await _httpClient.PostAsJsonAsync("/api/driver", testDriver);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);

            var actualData = _factory.GetLastDriverObject();

            Assert.NotNull(actualData);
            Assert.Equal(testDriver.FirstName, actualData.FirstName);
            Assert.Equal(testDriver.LastName, actualData.LastName);
            Assert.Equal(testDriver.Phone, actualData.Phone);
            Assert.Equal(testDriver.Email, actualData.Email);
        }
    }
}
