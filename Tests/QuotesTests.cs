using SimpsonsApiTests.Core;
using SimpsonsApiTests.Helpers;
using SimpsonsApiTests.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpsonsApiTests.Tests
{
    public class QuotesTests : BaseTest
    {
        [Test]
        public async Task Get_Default_Quotes_Returns_200_And_ValidQuote()
        {
            var response = await ApiClient.GetAsync<List<Quote>>("/quotes");

            ResponseAssertions.AssertStatus(response, 200);

            var quotes = response.Data;
            Assert.That(quotes, Is.Not.Null);
            Assert.That(quotes!.Count, Is.GreaterThan(0));

            ResponseAssertions.AssertNotEmpty(quotes![0].SimpsonQuote, "Quote");
            ResponseAssertions.AssertNotEmpty(quotes![0].Character, "Character");
        }
    }
}