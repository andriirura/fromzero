using System;
using FluentAssertions;
using NUnit.Framework;

namespace TestProject1.SimpleTasks
{
    [TestFixture]
    public class Basic25Test
    {
        [Test]
        public void Basic25()
        {
            OddNumbers();
        }
        public static void OddNumbers()
        {
            
            for (int i = 0; i <= 99; i++)
            {
                if (i % 2 != 0 )
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
}