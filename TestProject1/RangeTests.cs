using BusinessLogic;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        [TestCase(9,12,31,10)]
        [TestCase(-2, 2, 3, -1)]
        [TestCase(0, 10, 13, 3)]
        [TestCase(10, 14, 23, 11)]
        [TestCase(7, 12, 14, 9)]

        public void RangeTest(int minren, int maxren,int num,int expectedResult)
        {
            int result = RangeLogic.NormalizeRange(minren,maxren,num);

            result.Should().Be(expectedResult);
        }
    }
}