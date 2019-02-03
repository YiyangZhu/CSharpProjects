using System;
using System.Collections.Generic;

namespace Chapter3
{
    public class TypeParameter
    {
        public TypeParameter()
        {
        }

        public static void Demo()
        {
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);
            Converter<int, double> converter = TakeSquareRoot;
            List<double> doubles;
            doubles = integers.ConvertAll<double>(converter);
            foreach(double d in doubles)
            {
                Console.WriteLine(d);
            }

            List<string> list1 = MakeList<string>("Line 1", "Line 2");
            foreach(string x in list1)
            {
                Console.WriteLine(x);
            }
        }

        public class Dictionary<TKey, TValue>
        {
    
            Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

            public Dictionary()
            {

            }

            public void Add(TKey key, TValue value)
            {

            }

            public TValue this[TKey key]
            {
                get { return dict[key]; }
                set { dict[key] = value; }
            }

            public bool ContainsValue(TValue value)
            {
                if (dict.ContainsValue(value))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool ContainsKey(TKey key)
            {
                if (dict.ContainsKey(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        public static List<T> MakeList<T>(T first, T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

    }
}
