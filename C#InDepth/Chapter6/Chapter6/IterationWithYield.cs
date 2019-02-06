using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter6
{
    public class IterationWithYield
    {
        static readonly string Padding = new string(' ', 30);
        static IEnumerable<int> CreateEnumerable()
        {
            Console.WriteLine("{0}Start of CreateEnumerable()", Padding);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}About to yield {1}", Padding, i);
                yield return i;
                Console.WriteLine("{0}Yielding final value", Padding);
            }
            Console.WriteLine("{0}Yielding final value", Padding);
        }

        public object[] values;
        public int startingPoint;

        public IterationWithYield()
        {
        }

        public static void Demo()
        {
            IEnumerable<int> iterable = CreateEnumerable();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("Starting to iterate");
            while (true)
            {
                Console.WriteLine("Calling MoveNext()...");
                bool result = iterator.MoveNext();
                Console.WriteLine("...MoveNext result = {0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("Fetching Current...");
                Console.WriteLine("... Current result = {0}", iterator.Current);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startingPoint) % values.Length];
            }
        }
    }
}
