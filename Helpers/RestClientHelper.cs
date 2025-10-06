using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ApiTests.Helpers
{
    public static class RestClientHelper
    {
        private static RestClient GetClient(string baseUrl)
        {
            return new RestClient(new RestClientOptions(baseUrl)
            {
                ThrowOnAnyError = false
            });
        }

        public static async Task<RestResponse> PostAsync(string baseUrl, string endpoint, object body)
        {
            var client = GetClient(baseUrl);
            var request = new RestRequest(endpoint, Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddJsonBody(body);

            return await client.ExecuteAsync(request);
        }

        public static T DeserializeResponse<T>(RestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
