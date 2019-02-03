using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Chapter3
{
    public class TypeConstraints
    {
        public TypeConstraints()
        {
        }

        public static void Demo()
        {
            List<string> list = MakeList("Line 1", "Line 2");
            Console.WriteLine(CompareToDefault("x"));
            Console.WriteLine(CompareToDefault(10));
            Console.WriteLine(CompareToDefault(0));
            Console.WriteLine(CompareToDefault(-10));
            Console.WriteLine(CompareToDefault(DateTime.MinValue));

            string name = "Jon";
            string intro1 = "My name is " + name;
            string intro2 = "My name is " + name;
            Console.WriteLine(intro1 == intro2);
            Console.WriteLine(AreReferenceEqual(intro1, intro2));

            Pair<int, string> pair = new Pair<int, string>(10, "value");
            Console.WriteLine("hash code of pair is: " + pair.GetHashCode());
        }

        public sealed class Pair<T1, T2> : IEquatable<Pair<T1, T2>>
        {
            private static readonly IEqualityComparer<T1> FirstComparer = EqualityComparer<T1>.Default;
            private static readonly IEqualityComparer<T2> SecondComparer = EqualityComparer<T2>.Default;

            private readonly T1 first;
            private readonly T2 second;

            public Pair(T1 first, T2 second)
            {
                this.first = first;
                this.second = second;
            }

            public T1 First { get { return first; } }
            public T2 Second { get { return second; } }

            public bool Equals(Pair<T1, T2> other)
            {
                return other != null && FirstComparer.Equals(this.First, other.First) && SecondComparer.Equals(this.Second, other.Second);
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as Pair<T1, T2>);
            }

            public override int GetHashCode()
            {
                return FirstComparer.GetHashCode(first) * 37 + SecondComparer.GetHashCode(second);
            }
        }

        public static bool AreReferenceEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }

        public static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }


        public static List<T> MakeList<T>(T first, T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }

        public struct RefSample<T> where T : class
        {

        }

        public class ValSample<T> where T : struct
        {

        }

        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        public class Sample<T> where T : Stream, IEnumerable<string>, IComparable<int>
        {

        }

        /*
        Not valid: DUE TO MULTIPLE CONSTRAINTS

        public class SampleTwo<T> where T : Stream, ArrayList, IComparable<int>
        {

        }
        */       
    }
}
