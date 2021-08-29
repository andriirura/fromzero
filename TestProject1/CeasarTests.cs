using BusinessLogic;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using FluentAssertions;

namespace TestProject1
{
    [TestFixture]
    public class CeasarTests
    {
        [Test]
        [TestCase("zoo",2,"bqq")]
        [TestCase("zoo", 0, "zoo")]
        [TestCase("abc", -2, "yza")]
        public void CeasarTest(string text, int key, string expectedResult)
        {
            string result = CeasarLogic.EncodeCeasar(text, key);

            result.Should().Be(expectedResult);
        }
    }
}