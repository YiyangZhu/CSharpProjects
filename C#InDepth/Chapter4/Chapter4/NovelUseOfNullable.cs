using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter4
{
    public class NovelUseOfNullable
    {
        public NovelUseOfNullable()
        {
        }

        public static void Demo()
        {
            int? parsed = TryParse("Not valid");
            if(parsed != null)
            {
                Console.WriteLine("Parsed to {0}", parsed.Value);
            }
            else
            {
                Console.WriteLine("Couldn't parse");
            }
        }

        public static int? TryParse(string text)
        {
            int ret;
            if(int.TryParse(text, out ret))
            {
                return ret;
            }
            else
            {
                return null;
            }
        }

        public class Product
        {
            public int Price;
            public int Popularity;
            public string Name;
        }

        public int Compare(Product first, Product second)
        {
            int ret = second.Popularity.CompareTo(first.Popularity);
            if(ret != 0)
            {
                return ret;
            }
            ret = first.Price.CompareTo(second.Price);
            if(ret != 0)
            {
                return ret;
            }
            return first.Name.CompareTo(second.Name);
        }

        public static class PartialComparer
        {
            public static int? Compare<T>(T first, T second)
            {
                return Compare(Comparer<T>.Default, first, second);
            }
            public static int? Compare<T>(IComparer<T> comparer,
                                          T first, T second)
            {
                int ret = comparer.Compare(first, second);
                return ret == 0 ? new int?() : ret;
            }
            public static int? ReferenceCompare<T>(T first, T second)
               where T : class
            {
                return first == second ? 0
                    : first == null ? -1
                    : second == null ? 1
                    : new int?();
            }

        }

    }
}
