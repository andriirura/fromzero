using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TestsELEKS
{
    class Program
    {
        static void Main()
        {
            int i = 3;
            int j;
            method1(ref i);
         
            Console.WriteLine(i+ " ");

            static void method1(ref int x)
            {
                x = 5;
                x = x + 5;
            }
          


        }
}
}
