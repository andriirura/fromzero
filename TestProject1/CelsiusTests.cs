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
        [TestCase(10, "Very Cold weather")]
        [TestCase(20, "Cold weather")]
        [TestCase(30, "Normal in Temp")]
        [TestCase(30, "then Its Very Hot")]
        public void CelsiusTest(int temp, string expectedResult)
        {
            string result = CelsiusLogic.Celsius(temp);

            result.Should().Be(expectedResult);
        }
    }
}
