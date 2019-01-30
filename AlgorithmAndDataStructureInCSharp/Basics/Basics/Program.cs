using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numBase = 2;
            int exp = 16;
            int result = 1;
            while(exp > 0)
            {
                result *= numBase;
                exp--;
            }
            Console.WriteLine($"Result is {result}");

            int[] nums = { 5, 10, 3, 2, 4 };
            BubbleSort.BubbleSort_(nums);


            int[] nums2 = { 7, 8, 4, 6, 2, 1 };
            InsertionSort.InsertionSort_(nums2);

            int[] nums3 = { 7, 8, 4, 6, 2, 1 };
            SelectionSort.SelectionSort_(nums3);

            int[] nums4 = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSort.MergeSort_(nums4,0,6);

            int[] nums5 = { 38, 27, 43, 3, 9, 82, 10 };
            QuickSort.QuickSort_(nums5, 0, 6);
            DisplayArray(nums5);
            */

            int[] nums6 = { 38, 27, 43, 3, 9, 82, 10 };
            Console.Write(LinearSearch.LinearSearch_(nums6,27));

        }

        static void DisplayArray(int[] nums)
        {
            Console.Write("After: ");
            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine(nums[nums.Length - 1]);
        }

    }
}

