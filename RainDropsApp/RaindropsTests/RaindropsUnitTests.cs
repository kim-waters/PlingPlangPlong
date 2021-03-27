using NUnit.Framework;
using RainDropsApp;

namespace RainDropsTests
{
    public class Tests
    {
        [TestCase(6, "Pling")]
        [TestCase(10, "Plang")]
        [TestCase(28, "Plong")]
        [TestCase(30, "PlingPlang")]
        [TestCase(42, "PlingPlong")]
        [TestCase(70, "PlangPlong")]
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(121550625, "PlingPlangPlong")]
        [TestCase(34, "34")]
        [TestCase(0, "0")]
        public void WhenAValidIntegerIsPassedToTheMethod_TheCorrectStringIsReturned(int num, string expectedString)
        {
            var result = Raindrops.GetRaindropsString(num);
            Assert.That(result, Is.EqualTo(expectedString));
        }

        [TestCase(-6, "Pling")]
        [TestCase(-10, "Plang")]
        [TestCase(-28, "Plong")]
        [TestCase(-30, "PlingPlang")]
        [TestCase(-42, "PlingPlong")]
        [TestCase(-70, "PlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(-121550625, "PlingPlangPlong")]
        [TestCase(-34, "34")]
        public void WhenANegativeIntegerIsPassedToTheMethod_TheCorrectStringIsStillReturned(int num, string expectedString)
        {
            var result = Raindrops.GetRaindropsString(num);
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}