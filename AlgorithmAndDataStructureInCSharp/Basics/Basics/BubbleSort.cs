using System;
namespace Basics
{
    public class BubbleSort
    {
        public BubbleSort()
        {
        }

        public static void BubbleSort_(int[] nums)
        {
            Console.WriteLine("Before: 5, 10, 3, 2, 4 ");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(nums, j, j + 1);
                    }
                }
            }
            Console.Write("After: ");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine("{0}", nums[nums.Length - 1]);
        }

        static void Swap(int[] nums, int index1, int index2)
        {
            if (nums[index1] > nums[index2])
            {
                int temp = nums[index1];
                nums[index1] = nums[index2];
                nums[index2] = temp;
            }
        }
    }
}
