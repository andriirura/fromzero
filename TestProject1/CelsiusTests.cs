using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    class CelsiusTests
    {
        [Test]
        [TestCase(40,"then Its Very Hot")]
        [TestCase(-5, "Freezing weather")]
        [TestCase(10, "Cold weather")]
        [TestCase(20, "Normal in Temp")]
        [TestCase(30, "Its Hot")]
        [TestCase(30, "Its Hot")]
        public void CelsiusTest(int temp, string expectedResult)
        {
            string result = CelsiusLogic.Celsius(temp);

            result.Should().Be(expectedResult);
        }
    }
}
