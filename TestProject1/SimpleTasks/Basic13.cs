using System;
using NUnit.Framework;

namespace TestProject1.SimpleTasks
{
    //https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-13.php
    [TestFixture]
    public class Basic13Test
    {
        [Test]
        [TestCase('x',4,5)]
        [TestCase('x',10,10)]
        public void Basic13( char symbol, int x, int y )
        {
            Print(symbol,x,y);
        }

        public static void Print(char symbol, int x, int y)
        {
            //print first row

            for (int i = 0; i < y; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            //print everything in between
            for (int i = 0; i < x - 2; i++)
            {
                // print symbol
                Console.Write(symbol);
                // print spaces   width -2
                for (int j = 0; j < y - 2; j++)
                {
                    Console.Write(" ");
                }
                // print symbol
                Console.Write(symbol);
                Console.WriteLine();
            }

            //print last row
            for (int i = 0; i < y; i++)
            {
                Console.Write(symbol);
            }


        }
    }
}