using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapyear
{
    public class BusinessLogic
    {
        public static bool IsLeapYear(int year)
        {
            bool result = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                }
                else
                {
                    result = true;
                }

            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
