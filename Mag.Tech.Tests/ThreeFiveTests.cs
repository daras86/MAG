using NUnit.Framework;
using Mag.Tech.ThreeFive;

namespace Mag.Tech.Tests
{
    [TestFixture]
    public class ThreeFiveTests
    {
        [TestCase(1, "1")]
        [TestCase(3, "1\n2\nThree")]
        [TestCase(-1, "Invalid")]
        [TestCase(0, "Invalid")]
        [TestCase(5, "1\n2\nThree\n4\nFive")]
        [TestCase(15, "1\n2\nThree\n4\nFive\nThree\n7\n8\nThree\nFive\n11\nThree\n13\n14\nThreeFive")]
        [TestCase(30, "1\n2\nThree\n4\nFive\nThree\n7\n8\nThree\nFive\n11\nThree\n13\n14\nThreeFive\n16\n17\nThree\n19\nFive\nThree\n22\n23\nThree\nFive\n26\nThree\n28\n29\nThreeFive")]
        public void WhenRequestingThreeFiveString(int n, string expectedResult)
        {
            var threeFiveStringBuilder = new ThreeFiveStringBuilder();

            var result = threeFiveStringBuilder.Build(n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
