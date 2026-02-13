using RestSharp;
using System.Threading.Tasks;

namespace SimpsonsApiTests.Core
{
    public class ApiClient
    {
        private readonly RestClient _client;
        public ApiClient(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }
        public async Task<RestResponse> GetAsync(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            return await _client.ExecuteAsync(request);
        }

        public async Task<RestResponse<T>> GetAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.Get);
            return await _client.ExecuteAsync<T>(request);
        }
    }
}