using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    public class BinaryFun
    {
        public static void Run()
        {
            sbyte a = sbyte.MaxValue;
            a++;

            Console.WriteLine(a);
            

            string s = "hello";
            string base64encodedString = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(s));
            Console.WriteLine(base64encodedString);

            var deJaPracuu = Zones.Naukova | Zones.Levandivka;
            Console.WriteLine($"{Convert.ToString((int)deJaPracuu, 2)}");
        }
    }

    [Flags]
    enum Zones
    {
        Naukova = 1,
        Maiorivka = 2,
        Levandivka = 4,
        AllLviv = Naukova | Maiorivka | Levandivka
    }

    [Flags]
    enum CryptoDataTypes
    {
        Lenta = 1,
        Stakan = 2,
        Graphic = 4,
        AllData = Lenta | Stakan | Graphic
    }
}
