using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chapter14
{
    public static class DynamicTyping
    {

        private static bool AddConditionallyImpl<T>(IList<T> list, T item)
        {
            if(list.Count < 10)
            {
                list.Add(item);
                return true;
            }
            return false;
        }

        public static bool AddConditionally(dynamic list, dynamic item)
        {
            return AddConditionallyImpl(list, item);
        }

        public static void Demo()
        {
            object list = new List<string> { "x", "y" };
            object item = "z";
            Console.WriteLine(AddConditionally(list, item));
        }

        public static T DynamicSum<T>(this IEnumerable<T> source)
        {
            dynamic total = default(T);
            foreach(T element in source)
            {
                total = (T)(total + element);
            }
            return total;
        }

        public static void Demo2()
        {
            byte[] bytes = new byte[] { 1, 2, 3 };
            Console.WriteLine(DynamicSum(bytes));
        }

        public static void Demo3()
        {
            var times = new List<TimeSpan>
            {
                new TimeSpan(2), new TimeSpan(0,25,0),new TimeSpan(0,0,30),
                new TimeSpan(0,0,45),new TimeSpan(0,40,0)
            };
            Console.WriteLine(DynamicSum(times));
        }

        public static void Demo4()
        {
            PrintCount(new BitArray(10));
            PrintCount(new HashSet<int> { 3, 5 });
            PrintCount(new List<int> { 1, 2, 3 });
        }

        public static void PrintCount(IEnumerable collection)
        {
            dynamic d = collection;
            int count = d.Count;
            Console.WriteLine(count);
        }
    }
}
