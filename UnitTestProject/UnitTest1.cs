using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetAllApiTest()
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("api/student");
            //  Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(200, (int)response.StatusCode);
        }
        //[Fact]
        [Theory]
        [InlineData(10,200)]
        [InlineData(60,200)]
        [InlineData(61,200)]
        [InlineData(62,200)]
        [InlineData(68,200)]
        public async Task GetByIdTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync($"api/student/{id}");
            Assert.Equal(expected, (int)response.StatusCode);
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}