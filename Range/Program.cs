using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a range from : ");
            int minren = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a range to: ");
            int maxren = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = BusinessLogic.RangeLogic.NormalizeRange(minren,maxren,num);

            
            Console.WriteLine(result);
            
        }
    }
}
