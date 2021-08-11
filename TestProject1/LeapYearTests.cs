using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    class LeapYearTests
    {
        [Test]
        [TestCase(2020,true)]
        [TestCase(2000, false)]
        [TestCase(2017, false)]
        [TestCase(1900, false)]
        public void LeapYearTest(int year , bool expectedResult)
        {
            bool result = LeapYear.IsLeapYear(year);

            result.Should().Be(expectedResult);
        }

    }
}
