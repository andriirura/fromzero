namespace BusinessLogic
{
    public class RangeLogic
    {
        public static int NormalizeRange(int minren, int maxren, int num)
        {
            int range = maxren - minren;
            int rangescount = (num - minren) / range;
            int result = num - rangescount * range;
            return result;
        }
    }
}