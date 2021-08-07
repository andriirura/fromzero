using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            // data input
            Console.Write("Input a year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            // business logic
            bool isLeapYear = BusinessLogic.IsLeapYear(year);
            
            // output data
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

       


    }
}
