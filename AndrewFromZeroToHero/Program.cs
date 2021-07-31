using System;
using System.Net.NetworkInformation;

namespace AndrewFromZeroToHero
{
    public class Program
    {
        static void Main(string[] args)
        {
            // input values
            Console.WriteLine("Hello World!");

            int a = 0;
            int b = 0;

            //string inputA = Console.ReadLine();
            //string inputB = Console.ReadLine();

            //a = Convert.ToInt32(inputA);
            //b = Convert.ToInt32(inputB);

            //// do smth
            //int sum = Sum(a, b);

            int[] numbers = new[] {3, 5, 8, 3, 10};

            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100);
            }



            numbers[3] = 444;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            // print results
            //Console.WriteLine($"Sum = {sum}");
        }



        public static int Sum(int a, int b)
        {
            return a + b;
        }


    }
}
