using System;
namespace Basics
{
    public class SelectionSort
    {
        public SelectionSort()
        {
        }

        //selection sort: in-place comparison sort
        public static void SelectionSort_(int[] nums)
        {
            Console.Write("Before: ");
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine(nums[n - 1]);

            for (int i = 0; i < n; i++)
            {
                int smallest = nums[i];
                int smallIndex = i;
                for (int j = i; j < n; j++)
                {
                    if (nums[j] < smallest)
                    {
                        smallest = nums[j];
                        smallIndex = j;
                    }
                }
                Swap(nums, i, smallIndex);
            }

            Console.Write("After: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine(nums[n - 1]);
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
