using System;
using BusinessLogic;

namespace Ceasar
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data

            Console.Write("Enter the text: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            
            //business logic
            string code = CeasarLogic.EncodeCeasar(text, key);
            //output data
            Console.Write($"{code} ");

        }
    }
}

