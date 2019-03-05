using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter14
{
    public class DynamicOverloadResolution
    {
        public DynamicOverloadResolution()
        {
        }

        public class Base
        {
            public void Execute(object x)
            {
                Console.WriteLine("object");
            }
        }

        public class Derived: Base
        {
            public void Execute(string x)
            {
                Console.WriteLine("string");
            }
        }

        public static void Demo()
        {
            Base receiver = new Derived();
            dynamic d = "text";
            receiver.Execute(d);
        }

        public static void Demo2()
        {
            dynamic size = 5;
            var numbers = Enumerable.Range(10, 10);
            //follows: compile time error
            //var error = numbers.Take(size);
            var workaround1 = numbers.Take((int)size);
            var workaround2 = Enumerable.Take(numbers, size);
            Console.WriteLine(workaround1);
            Console.WriteLine(workaround2);
        }

        public static void Demo3()
        {
            var list = new List<dynamic> { 50, 5m, 5d };
            var query = from number in list
                        where number > 4
                        select (number / 20) * 10;

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
