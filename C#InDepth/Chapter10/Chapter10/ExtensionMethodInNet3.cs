using System;
using System.Linq;

namespace Chapter10
{
    public class ExtensionMethodInNet3
    {
        public ExtensionMethodInNet3()
        {
        }

        public static void Demo()
        {
            var collection = Enumerable.Range(0, 10);
            foreach(var element in collection)
            {
                Console.WriteLine(element);
            }
        }

        public static void Demo2()
        {
            var collecion = Enumerable.Range(0, 10)
                .Where(x => x % 2 != 0)
                .Reverse();
            foreach (var i in collecion)
            {
                Console.WriteLine(i);
            }
        }

        public static void Demo3()
        {
            String builder = "1 < 3 == true";
            Console.WriteLine("Before replace: " + builder);
            builder = builder.Replace("<", "lt")
                .Replace(">", "gt")
                .Replace("==", "is");
            Console.WriteLine("After replace: " + builder);
        }
    }
}
