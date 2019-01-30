using System;
namespace Basics
{
    public class QuickSort
    {
        public QuickSort()
        {
        }

        public static void QuickSort_(int[] nums, int start, int end)
        {
            if(start == end)
            {
                return;
            }
            if(end - start == 6)
            {
                DisplayArray(nums);
            }
            int PivotIndex = Partition(nums, start, end);
            if(PivotIndex - 1 > start)
            {
                QuickSort_(nums, start, PivotIndex - 1);
            }
            if(PivotIndex + 1 < end)
            {
                QuickSort_(nums, PivotIndex + 1, end);
            }
        }

        static int Partition(int[] nums, int start, int end)
        {
            int i = start - 1;
            int j = start;
            int pivot = nums[end];
            for(j = start; j < end; j++)
            {
                if(nums[j] < pivot )
                {
                    if (nums[i + 1] > pivot)
                    {
                        Swap(nums, i + 1, j);
                    }
                    i++;
                }
            }
            Swap(nums, i + 1, end);
            return i + 1;
        }

        static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

        static void DisplayArray(int[] nums)
        {
            Console.Write("Before: ");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine(nums[nums.Length - 1]);
        }
    }
}
