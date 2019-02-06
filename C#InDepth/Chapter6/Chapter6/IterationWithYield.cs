using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

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

            Console.WriteLine("");
            DateTime stop = DateTime.Now.AddSeconds(2);
            foreach(int i in CountWithTimeLimit(stop))
            {
                Console.WriteLine($"Received {i}");
                Thread.Sleep(300);
            }

            Console.WriteLine("");
            DateTime stop2 = DateTime.Now.AddSeconds(2);
            foreach (int i in CountWithTimeLimitFinal(stop2))
            {
                Console.WriteLine($"Received {i}");
                Thread.Sleep(300);
            }

            Console.WriteLine("");
            DateTime stop3 = DateTime.Now.AddSeconds(2); 
            IEnumerable<int> iterable3 = CountWithTimeLimit(stop3); 
            IEnumerator<int> iterator3 = iterable3.GetEnumerator();
            iterator.MoveNext();
            Console.WriteLine("Received {0}", iterator3.Current);
            iterator.MoveNext();
            Console.WriteLine("Received {0}", iterator3.Current);
        }

        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < values.Length; index++)
            {
                yield return values[(index + startingPoint) % values.Length];
            }
        }

        public static IEnumerable<int> CountWithTimeLimit(DateTime limit)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(DateTime.Now >= limit)
                {
                    yield break;
                }
                yield return i;
            }
        }

        public static IEnumerable<int> CountWithTimeLimitFinal(DateTime limit)
        {
            try
            {
                for(int i = 1; i < 100; i++)
                {
                    if(DateTime.Now >= limit)
                    {
                        yield break;
                    }
                    yield return i;
                }
            }
            finally
            {
                Console.WriteLine("Stopping!");
            }
        }
    }
}
