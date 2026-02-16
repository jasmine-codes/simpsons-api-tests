using NUnit.Framework;

namespace SimpsonsApiTests.Core
{
    public abstract class BaseTest
    {
        protected ApiClient ApiClient = null!;

        [SetUp]
        public void SetUp()
        {
            ApiClient = new ApiClient("https://thesimpsonsquoteapi.glitch.me");
        }
    }
}