using System;
namespace Basics
{
    public class BinarySearch
    {
        public BinarySearch()
        {
        }

        public static int BinarySearch_(int[] nums, int number)
        {
            int index = -1;
            int n = nums.Length;
            index = SearchHelper(nums, 0, n - 1, number);
            return index;
        }

        static int SearchHelper(int[] nums, int start, int end, int number)
        {
            int middle = (end - start) / 2 + start;
            if(start == end)
            {
                if(nums[start] == number)
                {
                    return start;
                }
                else
                {
                    return -1;
                }
            }
            if (nums[middle] == number)
            {
                return middle;
            } 
            else if(nums[middle] < number)
            {
                return SearchHelper(nums, middle + 1, end, number);
            }
            else
            {
                return SearchHelper(nums, start, middle - 1, number);
            }
        }
    }
}
