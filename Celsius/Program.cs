using System;
using BusinessLogic;

namespace Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            // data input
            Console.Write("Enter the temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            // business logic
            string temperatureDescription = CelsiusLogic.Celsius(temp);

            // output data
            
                Console.WriteLine($"{temperatureDescription} ");

        }
    }
}
