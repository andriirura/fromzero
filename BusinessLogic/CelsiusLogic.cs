using System;
using System.Diagnostics;

namespace BusinessLogic
{
    public class CelsiusLogic
    {
        public static string Celsius(int temp)
        {
            string result = String.Empty;
            if (temp < 0)
            {
                result = "Freezing weather";
            }

            if (temp >= 0 && temp < 10)
            {
                result = "Very Cold weather";
            }

            if (temp >= 10 && temp < 20)
            {
                result = "Cold weather";
            }

            if (temp >= 20 && temp < 30)
            {
                result = "Normal in Temp";
            }

            if (temp >= 30 && temp < 40)
            {
                result = "Its Hot";
            }

            if (temp >= 40)
            {
                result = "then Its Very Hot";
            }
            return result;
        }

        //public static string Celsius2(int temp)
        //{
        //    string result = String.Empty;
        //    result = switch temp
        //    {

        //    }
        //    return result;
        //}
    }
}