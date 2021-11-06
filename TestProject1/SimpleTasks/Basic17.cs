using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace TestProject1.SimpleTasks
{
    //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-17.php
    public class Basic17
    {
        [TestFixture]
        class Basic17test
        {
            [Test]
            [TestCase("hello", "hhelloh")]
            [TestCase("ab", "aaba")]
            [TestCase("a", "a")]
            [TestCase("", "")]
            public void Basic17(string input, string expectedResult)
            {
                string result = AddFirstAndLast(input);
                result.Should().Be(expectedResult);
            }

            public static string AddFirstAndLast(string text)
            {
                if (text.Length <= 1)
                    return text;

                char first = text.First();
                // string result = first + text + first;
                string result = text.Insert(0, first.ToString());
                result = result.Insert(result.Length, first.ToString());

                return result;
            }
        }
    }
}