using RestSharp;
using NUnit.Framework;
using SimpsonsApiTests.Models;

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
            Assert.That(value, Is.Not.Null.And.Not.Empty, $"{fieldName} should not be empty");
        }

        public static void AssertValidQuote(Quote q)
        {
            AssertNotEmpty(q.SimpsonQuote, "Quote");
            AssertNotEmpty(q.Character, "Character");
            
        }
    }
}