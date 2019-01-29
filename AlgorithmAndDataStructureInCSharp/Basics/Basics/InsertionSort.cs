using System;
namespace Basics
{
    public class InsertionSort
    {
        public InsertionSort()
        {
        }

        public static void InsertionSort_(int[] nums)
        {
            Console.Write("Before: ");
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine(nums[n - 1]);

            for (int i = 1; i < n; i++)
            {
                int k = 0;
                int j = 0;
                int temp = 0;
                for (j = 0; j <= i - 1; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        for (k = i; k > j; k--)
                        {
                            nums[k] = nums[k - 1];
                        }
                        nums[j] = temp;
                        break;
                    }
                }
            }
            Console.Write("After: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine(nums[n - 1]);
        }
    }
}
