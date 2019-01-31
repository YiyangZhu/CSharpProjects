using System;
namespace DataStructures
{
    public class MaximumDifference
    {
        public MaximumDifference()
        {
        }
        
        public static void Demo()
        {
            int[] array1 = { 3, 2, 9, 5 };
            int er1 = 7;
            Test(er1, MaximumDifference_(array1));

            int[] array2 = { 1, 1, 1, 1 };
            int er2 = 0;
            Test(er2, MaximumDifference_(array2));

        }

        public static void Test(int er, int ar)
        {
            Console.WriteLine($"expected result: {er}, actual result: {ar}");
        }

        public static int MaximumDifference_(int[] array)
        {
            int smallest = Int32.MaxValue;
            int largest = Int32.MinValue;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < smallest)
                {
                    smallest = array[i];
                }
                if(array[i] > largest)
                {
                    largest = array[i];
                }
            }
            return (largest - smallest);
        }
    }
}
