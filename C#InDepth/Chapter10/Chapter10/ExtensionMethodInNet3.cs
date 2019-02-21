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
            var collection = Enumerable.Range(0, 10)
                .Where(x => x % 2 != 0)
                .Reverse();

            foreach (var i in collection)
            {
                Console.WriteLine(i);
            }
        }

        public static void Demo3()
        {
            String builder = "1 < 3 == true";
            Console.WriteLine("Before replace: " + builder);
            builder = builder.Replace("<", "lt")
                .Replace(">","gt")
                .Replace("==","is");
            Console.WriteLine("After replace: " + builder);
        }

        public static void Demo4()
        {
            var collection = Enumerable.Range(0, 10)
                .Where(x => x % 2 != 0)
                .Reverse()
                .Select(x => new {Original = x, SquareRoot = Math.Sqrt(x) });
            foreach(var v in collection)
            {
                Console.WriteLine($"square root of {v.Original} is {v.SquareRoot}");
            }
        }

        public static void Demo5()
        {
            Console.WriteLine("Demonstrating square:");
            var collection = Enumerable.Range(1, 19)
                .Reverse()
                .Where(x => x % 2 == 0)
                .Select(x => new { Original = x, Square = Math.Pow(x,2)});

            foreach(var v in collection)
            {
                Console.WriteLine($"square of {v.Original} is {v.Square}");
            }
        }

        public static void Demo6()
        {
            Console.WriteLine("Demonstrating area of circle with known radius:");
            var collection = Enumerable.Range(10, 20)
                .Where(x => x % 3 == 0)
                .Reverse()
                .Select(x => new {Radius = x, Area = Math.PI * Math.Pow(x,2)});
            foreach(var v in collection)
            {
                Console.WriteLine($"The area of circle with radius {v.Radius} is {(int)v.Area}");
            }

        }

        public static void Demo7()
        {
            var collection = Enumerable.Range(-4, 9)
                .Select(x => new { Original = x, Square = x * x })
                .OrderBy(x => x.Square)
                .ThenByDescending(x => x.Original);
            foreach (var v in collection)
            {
                Console.WriteLine(v);
            }
        }

    }
}
