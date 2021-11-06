using System;

namespace CodeTester
{
    public class Arrays
    {
        public static void Run()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i * i;
            }

            Print(arr);

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(10);
            }
            Print(arr);


            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                matrix[i, i] = rand.Next(10);
            }
            Print(matrix);
        }

        public static void Print(int[] array)
        {
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}