using BusinessLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace TestProject1
{
    [TestFixture]
    public class LongestWordTests
    {
        [Test]
        [TestCase("Write a C# Sharp Program to display the following pattern using the alphabet.", "following")]
        [TestCase("A developer platform for building all your apps.", "developer")]
        public void LongestWordTest(string text, string expectedResult)
        {
            string result = LongestWordInString.GetLongestWord(text);

            result.Should().Be(expectedResult);
        }


        [Test]
        public void TestiTest()
        {
            List<int> numbers = new List<int>();

            int max = 0;// numbers[0];

            foreach (int item in numbers)
            {
                if (item > max )
                {
                    max = item;
                }
            }
            Console.WriteLine(max);
        }

    }
}
