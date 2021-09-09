using System;
using System.Collections;
using System.Collections.Generic;
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
        [TestCase("Hello123.", 2, "Jgnnq123.")]
        [TestCase("", 2, "")]
        public void CeasarTest(string text, int key, string expectedResult)
        {
            string result = CeasarLogic.EncodeCeasar3(text, key);

            result.Should().Be(expectedResult);
        }


        [Test]
        public void CeasarEdgeCases_NullParameter_ShouldThrowException()
        {
            Action action = () => CeasarLogic.EncodeCeasar2(null, 0);

            action.Should().Throw<Exception>()
                .WithMessage("You can't convert null values");
        }
    }
}