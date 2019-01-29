using System;
namespace Basics
{
    public class MergeSort
    {
        public MergeSort()
        {
        }

        public static void MergeSort_(int[] nums, int start, int end)
        {
            if(end - start + 1 == nums.Length)
            {
                Console.Write("Before: ");
                DisplayArray(nums);
            }
            if (start == end)
            {
                return;
            }
            if(end - start == 1)
            {
                if(nums[end] < nums[start])
                {
                    int temp = nums[end];
                    nums[end] = nums[start];
                    nums[start] = temp;
                }
                return;
            }
            int middle = (end - start) / 2 + start;
            MergeSort_(nums, start, middle);
            MergeSort_(nums, middle + 1, end);

            Merge(nums,start, middle, end);
        }

        static void Merge(int[] nums, int start, int middle, int end)
        {
            int i = start;
            int j = middle + 1;
            int[] newArray = new int[nums.Length];
            
            int index = start;
            int n = nums.Length;
            while (i != middle + 1 && j != end + 1)
            {
                if(nums[i] > nums[j])
                {
                    newArray[index] = nums[j];
                    j++;
                }
                else
                {
                    newArray[index] = nums[i];
                    i++;
                }
                index++;
            }

            if (j != end + 1)
            {
                while(j != end + 1)
                {
                    newArray[index] = nums[j];
                    j++;
                    index++;
                }
            }
            if (i != middle + 1)
            {
                while (i != middle + 1)
                {
                    newArray[index] = nums[i];
                    i++;
                    index++;
                }
            }

            for(int k = start; k <= end; k++)
            {
                nums[k] = newArray[k];
            }

            if (start == 0 && end == nums.Length - 1)
            {
                Console.Write("After: ");
                DisplayArray(nums);
            }
        }

        static void DisplayArray(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine(nums[n - 1]);
        }
    }
}
