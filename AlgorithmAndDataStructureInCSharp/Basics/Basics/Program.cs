using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
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
            BubbleSort(nums);

            int[] nums2 = { 7, 8, 4, 6, 2, 1 };
            InsertionSort(nums2);




        }

        static void BubbleSort(int[] nums)
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

        static void Swap(int[] nums, int index1,int index2)
        {
            if(nums[index1] > nums[index2])
            {
                int temp = nums[index1];
                nums[index1] = nums[index2];
                nums[index2] = temp;
            }
        }

        static void InsertionSort(int[] nums)
        {
            Console.Write("Before: ");
            int n = nums.Length;
            for(int i = 0; i < n-1; i++)
            {
                Console.Write(nums[i]+", ");
            }
            Console.WriteLine(nums[n-1]);

            for (int i = 1; i < n; i++)
            {
                int k = 0;
                int j = 0;
                int temp = 0;
                for(j = 0; j <= i-1; j++)
                {
                    if(nums[i] < nums[j])
                    {
                        temp = nums[i];
                        for(k = i; k > j; k--)
                        {
                            nums[k] = nums[k - 1];
                        }
                        nums[j] = temp;
                        break;
                    }
                }
            }
            Console.Write("After: ");
            for(int i = 0; i < n-1; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.Write(nums[n - 1]);
        }
    }
}
