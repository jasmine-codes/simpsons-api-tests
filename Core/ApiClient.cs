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
    }
}