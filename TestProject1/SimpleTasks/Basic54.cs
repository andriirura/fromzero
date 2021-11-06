using FluentAssertions;
using NUnit.Framework;

namespace TestProject1.SimpleTasks
{
    [TestFixture]

    public class Basic54Test
    {
        [Test]
        [TestCase(2021, 21)]
        [TestCase(1990,20)]
        [TestCase(1650,17)]
        public void Test54(int year,int expectedResult)
        {
            int result = GetCentury(year);
            result.Should().Be(expectedResult);
        }

        public int GetCentury(int year)
        {
            int result = year / 100 + 1;
            return result;
        }
    }
}