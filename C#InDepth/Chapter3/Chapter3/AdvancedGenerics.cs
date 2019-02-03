using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Chapter3
{
    public class AdvancedGenerics
    {
        public AdvancedGenerics()
        {
        }

        public static void Demo()
        {
            TypeWithField<int>.field = "First";
            TypeWithField<string>.field = "Second";
            TypeWithField<DateTime>.field = "Third";

            TypeWithField<int>.PrintField();
            TypeWithField<string>.PrintField();
            TypeWithField<DateTime>.PrintField();

            Outer<int>.Inner<string, DateTime>.DummyMethod();
            Outer<string>.Inner<int, int>.DummyMethod();
            Outer<object>.Inner<string, object>.DummyMethod();
            Outer<string>.Inner<string, object>.DummyMethod();
            Outer<object>.Inner<object, string>.DummyMethod();
            //the next line will not product a console statement, as the static class already executed, and static constructor for any closed type is only executed once
            Outer<string>.Inner<int, int>.DummyMethod();

            Console.WriteLine("");
            CountingEnumerable counter = new CountingEnumerable();
            foreach(int x in counter)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");
            DemonstrateTypeOf<int>();

            Console.WriteLine("");
            RetrievingGenericType();

            Console.WriteLine("");
            Type type = typeof(AdvancedGenerics);
            MethodInfo definition = type.GetMethod("PrintTypeParameter");

            MethodInfo constructed = definition.MakeGenericMethod(typeof(string));
            constructed.Invoke(null, null);
        }

        public class TypeWithField<T>
        {
            public static string field;
            public static void PrintField()
            {
                Console.WriteLine(field + ": " + typeof(T).Name);
            }
        }

        public class Outer<T>
        {
            public class Inner<U, V>
            {
                static Inner()
                {
                    Console.WriteLine("Outer<{0}>.Inner<{1},{2}>", typeof(T).Name, typeof(U).Name, typeof(V).Name);
                }

                public static void DummyMethod() { }
            }
        }

        public class CountingEnumerable: IEnumerable<int>
        {

     
            public IEnumerator<int> GetEnumerator()
            {
                return new CountingEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

        }

        class CountingEnumerator : IEnumerator<int>
        {
            int current = 1;
            public bool MoveNext()
            {
                current++;
                return current < 10;
            }

            public int Current { get { return current; } }

            object IEnumerator.Current { get { return Current; } }

            public void Reset()
            {
                current = -1;
            }

            public void Dispose() { }
        }


        public static void DemonstrateTypeOf<X>()
        {
            Console.WriteLine(typeof(X));
            Console.WriteLine(typeof(List<>));
            Console.WriteLine(typeof(Dictionary<,>));
            Console.WriteLine(typeof(List<X>));
            Console.WriteLine(typeof(Dictionary<string, X>));
            Console.WriteLine(typeof(List<long>));
            Console.WriteLine(typeof(Dictionary<long, Guid>));
        }

        public static void RetrievingGenericType()
        {
            string listTypeName = "System.Collections.Generic.List`1"; Type defByName = Type.GetType(listTypeName);
            Type closedByName = Type.GetType(listTypeName + "[System.String]"); Type closedByMethod = defByName.MakeGenericType(typeof(string)); Type closedByTypeof = typeof(List<string>);
            Console.WriteLine(closedByMethod == closedByName);
            Console.WriteLine(closedByName == closedByTypeof);
            Type defByTypeof = typeof(List<>);
            Type defByMethod = closedByName.GetGenericTypeDefinition();
            Console.WriteLine(defByMethod == defByName);
            Console.WriteLine(defByName == defByTypeof);
        }

        public static void PrintTypeParameter<T>()
        {
            Console.WriteLine(typeof(T));
        }
    }
}
