using NUnit.Framework;
using ApiTests.Helpers;
using ApiTests.Config;
using ApiTests.Models;
using FluentAssertions;
using System.Threading.Tasks;

namespace ApiTests.Tests
{
    [TestFixture]
    public class FeeCalculationTests
    {
        [Test]
        public async Task WhenRequestIsValid_ShouldReturnCorrectFee()
        {
            var request = TestDataGenerator.CreateValidFeeRequest();

            var response = await RestClientHelper.PostAsync(TestConfiguration.BaseUrl, TestConfiguration.FeeEndpoint, request);
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

            var feeResponse = RestClientHelper.DeserializeResponse<FeeResponse>(response);
            feeResponse.Status.Should().Be("success");
            feeResponse.Fee.Should().BeGreaterThan(0);
        }
    }
}
