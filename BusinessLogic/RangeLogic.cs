namespace BusinessLogic
{
    public class RangeLogic
    {
        /// <summary>
        /// Normalizes number into a range. Careful, maxren is not included.
        /// Example: 0 to 10  gives a result from 0 to 9!
        /// </summary>
        /// <param name="minren"></param>
        /// <param name="maxren"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int NormalizeRange(int minren, int maxren, int num)
        {
            int range = maxren - minren;
            int rangescount = (num - minren) / range;
            int result = num - rangescount * range;
            return result;
        }
    }
}