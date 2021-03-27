using NUnit.Framework;
using RainDropsApp;

namespace RainDropsTests
{
    public class Tests
    {
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(34, "34")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(121550625, "PlingPlangPlong")]
        public void WhenAValidIntegerIsPassedToTheMethod_TheCorrectStringIsReturned(int num, string expectedString)
        {
            var result = Raindrops.GetRaindropsString(num);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}