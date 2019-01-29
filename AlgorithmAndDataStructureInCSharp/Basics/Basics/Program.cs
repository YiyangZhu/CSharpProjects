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
            */

            int[] nums4 = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSort.MergeSort_(nums4,0,6);

        }

    }
}

