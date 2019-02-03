using System;
using System.Collections.Generic;

namespace Chapter3
{
    public class LimitationsOfGeneric
    {
        public LimitationsOfGeneric()
        {
        }

        public static void Demo()
        {
            List<String> strings = new List<String>();
            strings.Add("hello");
            String entry = strings[0];
            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }

        }

        public class ComparisonHelper<TBase, TDerived> : IComparer<TDerived> where TDerived : TBase
        {
            private readonly IComparer<TBase> comparer;

            public ComparisonHelper(IComparer<TBase> comparer)
            {
                this.comparer = comparer;
            }

            public int Compare(TDerived x, TDerived y)
            {
                return comparer.Compare(x, y);
            }
        }

        public T FindMean<T>(IEnumerable<T> data)
        {
            T sum = default(T);
            int count = 0;
            foreach(T datum in data)
            {
                //invalid
                /*
                sum += datum;
                */
                count++;
            }
            return sum;
        }
    }
}
