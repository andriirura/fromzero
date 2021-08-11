
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace TestProject1
{
    [TestFixture]
    public class LeetCodeTests
    {
        [Test]
        [TestCase(3, 12, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 2, 5)]
        public void SumTest(int first, int second, int expectedResult)
        {
            //int result = Program.Sum(first, second);

            //Assert.AreEqual(expectedResult, result);
        }


        [Test]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [TestCase(new[] { 5,8, 2, 0,14,4,9 }, 11, new[] { 2, 6 })]
        public void LC1_TwoSum_Test(int[] numbers, int target, int[] expectedResult)
        {
            int[] result = LeetcodeTasks.LC1_TwoSum(numbers, target);

            CollectionAssert.AreEqual(expectedResult, result);
        }

    }
}
