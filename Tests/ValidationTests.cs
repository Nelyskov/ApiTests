using NUnit.Framework;
using ApiTests.Helpers;
using ApiTests.Config;
using FluentAssertions;
using System.Threading.Tasks;

namespace ApiTests.Tests
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        public async Task WhenRequestIsInvalid_ShouldReturnBadRequest()
        {
            var invalidRequest = TestDataGenerator.CreateInvalidFeeRequest();

            var response = await RestClientHelper.PostAsync(TestConfiguration.BaseUrl, TestConfiguration.ValidationEndpoint, invalidRequest);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
            response.Content.Should().Contain("validation error");
        }
    }
}
