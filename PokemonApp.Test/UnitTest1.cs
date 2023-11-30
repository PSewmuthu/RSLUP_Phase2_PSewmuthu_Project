using Microsoft.AspNetCore.Mvc.Testing;

namespace PokemonApp.Test
{
    [TestClass]
    public class ApiTests
    {
        private HttpClient _httpClient;

        public ApiTests()
        {
            var webAppFactory = new WebApplicationFactory<Program>();
            _httpClient = webAppFactory.CreateDefaultClient();
        }

        [TestMethod]
        public async Task GetUserById()
        {
            var response = await _httpClient.GetAsync("");
            var stringResult = await response.Content.ReadAsStringAsync();

            Assert.AreEqual("Test User", stringResult );
        }
    }
}