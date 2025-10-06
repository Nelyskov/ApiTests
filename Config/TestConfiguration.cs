using System;

namespace ApiTests.Config
{
    public static class TestConfiguration
    {
        public static string BaseUrl => "https://api.example.com"; // заменить на реальный
        public static string FeeEndpoint => "/v1/fee/calculate";
        public static string ValidationEndpoint => "/v1/fee/validate";
    }
}
