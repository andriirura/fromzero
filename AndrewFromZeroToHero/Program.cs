using System;
using System.Net.NetworkInformation;
using System.Threading.Channels;

namespace AndrewFromZeroToHero
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            Console.WriteLine("m= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[n, m];

            //Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = 1; //rand.Next(100);
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{numbers[i, j]:D1} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            // fill upper right with zeros

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    numbers[i, j] = 0;
                }

            }

            // print
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{numbers[i, j]:D1} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i - 1; j < n; j++)
                {
                    numbers[i, j] = 0;
                }
            }



            // print
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{numbers[i, j]:D1} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            // print results
            //Console.WriteLine($"Sum = {sum}");
        }


    }
}
