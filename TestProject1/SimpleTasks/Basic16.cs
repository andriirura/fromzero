using System;
using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace TestProject1.SimpleTasks
{
    //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-16.php
    [TestFixture]
    class Basic16test
    {
        [Test]
        [TestCase("hello", "oellh")]
        [TestCase("ab", "ba")]
        [TestCase("a", "a")]
        [TestCase("", "")]
        public void Basic16(string input, string expectedResult)
        {
            string result = SwapFirstAndLast(input);
            result.Should().Be(expectedResult);
        }

        public static string SwapFirstAndLast(string text)
        {
            if (text.Length <= 1) 
                return text;

            char first = text.First();
            char last = text.Last();

            string tmp = text.Remove(0, 1);
            tmp = tmp.Remove(tmp.Length - 1, 1);

            //string result = last + tmp + first;
            //string result = $"{last}{tmp}{first}";
            string result = string.Concat(last, tmp, first);



            return result;
        }
    }
}