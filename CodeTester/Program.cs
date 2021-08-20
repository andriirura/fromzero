using System;

namespace Shifr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово,которое нужно зашифровать:");
            string s = Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            //abc наш алфавит
            Console.WriteLine("Укажите длину сдвига");
            int len = Convert.ToInt32(Console.ReadLine());
            // len - число сдвигов в сторону
            int a;
            string code = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int pos;
                char c = s[i];
                pos = abc.IndexOf(c);
                a = pos + len;
                code += abc[a];
            }

            Console.WriteLine(code);
            Console.ReadLine();
        }
    }
}