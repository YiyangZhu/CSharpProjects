using System;
using System.Collections.Generic;

namespace Chapter14
{
    public class DynamicBinding
    {
        public DynamicBinding()
        {
        }

        public static void Demo()
        {
            dynamic items = new List<string> { "First", "Second", "Third" };
            dynamic valueToAdd = "!";
            foreach(dynamic item in items)
            {
                string result = item + valueToAdd;
                Console.WriteLine(result);
            }
        }

        public static void Demo2()
        {
            dynamic items = new List<string> { "First", "Second", "Third" };
            dynamic valueToAdd = 2;
            foreach(dynamic item in items)
            {
                string result = item + valueToAdd;
                Console.WriteLine(result);
            }
        }

        public static void Demo3()
        {
            dynamic items = new List<int> { 1, 2, 3 };
            dynamic valueToAdd = 2;
            foreach (dynamic item in items)
            {
                //RuntimeBinderException: cannot implicitly convert type int to string
                //string result = item + valueToAdd;
                Console.WriteLine(item + valueToAdd);
            }
        }
    }
}
