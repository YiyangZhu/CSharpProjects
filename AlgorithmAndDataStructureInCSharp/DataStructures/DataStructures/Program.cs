using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayName = new int[10];
            int[] oldNumbers = { 1, 2, 3, 4, 5 };
            int number = oldNumbers[2];

            for(int i = 0; i < oldNumbers.Length; i++)
            {
                number = oldNumbers[i];
            }

            int[,] arrayNameTwo = new int[10, 10];
            int value = arrayNameTwo[0, 0];
            int value2 = arrayNameTwo[0, 1];
            int value3 = arrayNameTwo[1, 0];

            Type[][] jaggedArray = new Type[10][];
            jaggedArray[0] = new Type[5];
            jaggedArray[1] = new Type[7];
            jaggedArray[2] = new Type[21];


        }
    }
}
