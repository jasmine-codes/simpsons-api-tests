using RestSharp;
using System;

namespace SimpsonsApiTests.Helpers
{
    public static class TestLogger
    {
        public static void LogResponse(RestResponse response)
        {
            Console.WriteLine("---RESPONSE---");

            Console.WriteLine($"Status: {(int)response.StatusCode}");

            Console.WriteLine(response.Content);

            Console.WriteLine("----------------");
        }
    }
}