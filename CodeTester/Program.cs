using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CodeTester;

namespace Shifr
{
    

    class Program
    {
        static void Main(string[] args)
        {
           //GameCardExperiment.Run();
           //Classes.Run();
           //BinaryFun.Run();

           //Arrays.Run();
           int sum = 0;
           for (int i = 0; i < 5; i++)
           {
               sum = sum + i * 3;
           }
           Console.WriteLine(sum);

        }



    }
}