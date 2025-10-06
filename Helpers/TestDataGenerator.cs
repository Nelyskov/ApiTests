using ApiTests.Models;

namespace ApiTests.Helpers
{
    public static class TestDataGenerator
    {
        public static FeeRequest CreateValidFeeRequest()
        {
            return new FeeRequest
            {
                Amount = 100.0m,
                Currency = "USD",
                Country = "US",
                CustomerType = "Regular"
            };
        }

        public static FeeRequest CreateInvalidFeeRequest()
        {
            return new FeeRequest
            {
                Amount = -10,
                Currency = "",
                Country = "Unknown",
                CustomerType = "None"
            };
        }
    }
}
