using System;
using System.Globalization;

namespace Ceasar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            int number;
            string code = string.Empty;
            char[] abc =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };
            for (int i = 0; i < text.Length; i++)
            {
                int a;
                char item = text[i];
                a = abc.IndexOf(item);
                number = a + key;
                code = code + abc[number];

            }
            Console.Write($"{code} ");

        }
        }
    }

