using Mag.Tech.LookAndSay;
using NUnit.Framework;
using System;

namespace Mag.Tech.Tests
{
    [TestFixture]
    public class LookAndSayTests
    {
        [TestCase(1, 11)]
        [TestCase(0, 10)]
        [TestCase(11, 21)]
        [TestCase(21, 1211)]
        [TestCase(9000, 1930)]
        [TestCase(222222222222, 122)]
        [TestCase(3333000, 4330)]
        [TestCase(123456789, 111213141516171819)]
        public void WhenLookingAtNumber(long n, long expectedResult)
        {
            var parser = new LookAndSayParser();

            var result = parser.LookAndSay(n);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenLookingAtNegativeNumber()
        {
            var parser = new LookAndSayParser();

            Assert.Throws<ArgumentException>(() => parser.LookAndSay(-1));
        }
    }
}
