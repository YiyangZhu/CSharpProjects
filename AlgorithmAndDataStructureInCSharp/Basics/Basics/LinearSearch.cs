using System;
namespace Basics
{
    public class LinearSearch
    {
        public LinearSearch()
        {
        }

        public static int LinearSearch_(int[] nums, int number)
        {
            int index = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == number)
                {
                    return i;
                }
            }
            return index;
        }
    }
}
