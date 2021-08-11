namespace BusinessLogic
{
    public class LeetcodeTasks
    {
        public static int[] LC1_TwoSum(int[] nums, int target)
        {
            int index1 = 0;
            int index2 = 1;

            bool targetFound = false;


            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        targetFound = true;
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }

                if (targetFound)
                    break;
            }

            return new []{index1, index2};
        }
    }
}
