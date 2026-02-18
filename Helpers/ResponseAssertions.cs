using RestSharp;
using NUnit.Framework;

namespace SimpsonsApiTests.Helpers
{
    public static class ResponseAssertions
    {
        public static void AssertStatus (RestResponse response, int expected)
        {
            Assert.That((int)response.StatusCode, Is.EqualTo(expected),
            $"Expected status {expected} but got {(int)response.StatusCode}");
        }

        public static void AssertNotEmpty(string? value, string fieldName)
        {
            
        }
    }
}