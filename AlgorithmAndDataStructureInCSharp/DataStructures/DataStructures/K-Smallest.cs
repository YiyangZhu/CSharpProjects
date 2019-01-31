using System;
namespace DataStructures
{
    public class K_Smallest
    {
        public K_Smallest()
        {
        }

        public static void Demo()
        {  
            int[] array1 = { 2, 1, 4 };
            int k1 = 3;
            int number1 = 4;
            Test(Ksmallest(array1, k1), number1);

            int[] array2 = { 7, 2, 1, 6, 1 };
            int k2 = 4;
            int number2 = 7;
            Test(Ksmallest(array2, k2), number2);
        }

        public static int Ksmallest(int[] a, int k)
        {
            //quicksort a, time complexity: O(nlog(n))
            QuickSort(a, 0, a.Length - 1);
            DisplayArray(a);
            //find the k-smallest element, O(1)
            return FindKSmallest(a, k);
        }

        public static int FindKSmallest(int[] a, int k)
        {
            int i = 0;
            for(i = 0; i < a.Length; i++)
            {

                if(k == 1)
                {
                    break;
                }
                if((i < a.Length - 1) && (a[i] < a[i + 1]))
                {
                    k--;
                }
            }
            return a[i];
        }


        public static void Test(int actualResult, int expectResult)
        {
            Console.WriteLine($"actual result is {actualResult}, expected result is {expectResult}");
        }

        static void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivotIndex = Partition(a, start, end);
            QuickSort(a, start, pivotIndex - 1);
            QuickSort(a, pivotIndex + 1, end);
        }

        static int Partition(int[] a, int start, int end)
        {
            if(start == end )
            {
                return start;
            }
            int pivot = a[end];
            int pivotIndex = end;
            int i = start - 1;
            int j = start;
            for(int k = start; k < end; k++)
            {
                if(a[k] <= pivot & a[i+1] > pivot)
                {
                    Swap(a, i + 1, j);
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }
            if(a[i+1] > pivot)
            {
                Swap(a, i + 1, pivotIndex);
                pivotIndex = i + 1;
            }

            return pivotIndex;
        }

        static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        static void DisplayArray(int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
