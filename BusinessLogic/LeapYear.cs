namespace BusinessLogic
{
    public class LeapYear
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
