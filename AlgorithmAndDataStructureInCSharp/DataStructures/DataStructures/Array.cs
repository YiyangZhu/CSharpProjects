using System;
namespace DataStructures
{
    public class Array
    {
        public Array()
        {
        }

        public static void TypeArrayDemo()
        {
            Type[][] jaggedArray = new Type[10][];
            jaggedArray[0] = new Type[5];
            jaggedArray[1] = new Type[7];
            jaggedArray[2] = new Type[21];
            Console.WriteLine(jaggedArray.Length);
            Console.WriteLine(jaggedArray[1].Length);
        }

        public static void ArrayDemo()
        {
            int[] array1 = new int[10];
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int number = array2[2];
            for(int i = 0; i < array2.Length; i++)
            {
                number = array2[i];
            }
            foreach(int i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
