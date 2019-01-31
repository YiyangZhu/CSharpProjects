using System;
namespace DataStructures
{
    public class ClosestInteger
    {
        public ClosestInteger()
        {
        }

        public static void Demo()
        {
            int[] array = { 1, 3, 1, 1 };
            int result = 2;
            Test(array, result);
            int[] array2 = { -3, 2 };
            int result2 = 0;
            Test(array2, result2);
            int[] array3 = { -2, 4, -1, 6 };
            int result3 = 2;
            Test(array3, result3);
            int[] array4 = { -3,-3,-2 };
            int result4 = -3;
            Test(array4, result4);
            int[] array5 = { -2, -2, -2, 0 };
            int result5 = -2;
            Test(array5, result5);
            int[] array6 = { -2, -2, -1, 0 };
            int result6 = -1;
            Test(array6, result6);

        }

        static int Average(int[] a)
        {
            int sum = 0;
            Boolean negative = false;
            foreach (int i in a)
            {
                sum += i;
            }
            if (sum < 0)
            {
                negative = true;
                sum = -sum;
            }

            double sumDouble = (double)sum;
            double b = sumDouble / a.Length;
            int bTen = (int)(b * 10);
            if (bTen % 10 > 5)
            {
                bTen += 10;
            }
            else if (bTen % 10 == 5)
            {
                if (bTen % 2 != 0)
                {
                    bTen += 10;
                }
            }

            if (negative)
            {
                bTen = -bTen;
            }
            return bTen / 10;

        }

        static void Test(int[] array, int result)
        {
            Console.WriteLine($"expected result is {result}, actual result is {ClosestInteger.Average(array)}");
        }
    }
}
