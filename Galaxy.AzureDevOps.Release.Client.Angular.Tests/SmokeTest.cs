using NUnit.Framework;

namespace Tests
{
    public class SmokeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateSUM()
        {
            var A = 5;
            var B = 8;
            var result = A + B;
            Assert.AreEqual(13,result);
        }
    }
}