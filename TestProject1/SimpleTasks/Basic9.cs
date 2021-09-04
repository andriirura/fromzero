using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1.SimpleTasks
{
    //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-9.php
    [TestFixture]
    class Basic9test
    {
        [Test]
        [TestCase(new []{2,2,2,2}, 2)]
        [TestCase(new[] { 5, 5, 5, 5 }, 5)]
        [TestCase(new[] { 10,15, 20, 30 }, 18.75)]
        [TestCase(new[] { 10, 15, 20, 30,50,66 }, 31.83)]
        public void Basic9(int [] numbers, double expectedResult)
        {
            double result = AvarageNumber(numbers.ToList());

            result.Should().BeApproximately(expectedResult, 0.01);
        }

        public static double AvarageNumber(List<int> numbers)
        {
            int sum = 0;
            double result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                result = sum / (double)numbers.Count;
            }

            return result;
        }
    }
}
