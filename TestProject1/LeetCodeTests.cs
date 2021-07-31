using Microsoft.VisualStudio.TestTools.UnitTesting;
using AndrewFromZeroToHero;
using Program = AndrewFromZeroToHero.Program;

namespace TestProject1
{
    [TestClass]
    public class LeetCodeTests
    {
        [TestMethod]
        [DataRow(3, 12, 15)]
        [DataRow(0, 0, 0)]
        [DataRow(2, 2, 5)]
        public void SumTest(int first, int second, int expectedResult)
        {
            int result = Program.Sum(first, second);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        [DataRow(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [DataRow(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [DataRow(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [DataRow(new[] { 5,8, 2, 0,14,4,9 }, 11, new[] { 2, 6 })]
        public void LC1_TwoSum_Test(int[] numbers, int target, int[] expectedResult)
        {
            int[] result = LeetcodeTasks.LC1_TwoSum(numbers, target);

            CollectionAssert.AreEqual(expectedResult, result);
        }

    }
}
