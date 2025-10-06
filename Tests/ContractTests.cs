using NUnit.Framework;
using ApiTests.Helpers;
using ApiTests.Config;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ApiTests.Tests
{
    [TestFixture]
    public class ContractTests
    {
        [Test]
        public async Task Response_ShouldMatchContract()
        {
            var request = TestDataGenerator.CreateValidFeeRequest();
            var response = await RestClientHelper.PostAsync(TestConfiguration.BaseUrl, TestConfiguration.FeeEndpoint, request);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

            var json = JObject.Parse(response.Content);

            json.Should().ContainKey("fee");
            json.Should().ContainKey("currency");
            json.Should().ContainKey("status");
        }
    }
}
