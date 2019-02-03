using System;
namespace Chapter4
{
    public class SystemNullable
    {
        public SystemNullable()
        {
        }

        public static void Demo()
        {
            Nullable<int> x = 5;
            x = new Nullable<int>(5);
            Console.WriteLine("Instance with value:");
            Display(x);

            x = new Nullable<int>();
            Console.WriteLine("Instance with value:");
            Display(x);

            Console.WriteLine("");
            Nullable<int> nullable = 5;
            object boxed = nullable;
            Console.WriteLine(boxed.GetType());

            int normal = (int)boxed;
            Console.WriteLine(normal);

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable);

            nullable = new Nullable<int>();
            boxed = nullable;
            Console.WriteLine(boxed == null);

            nullable = (Nullable<int>)boxed;
            Console.WriteLine(nullable.HasValue);
        }

        public static void Display(Nullable<int> x)
        {
            Console.WriteLine("HasValue: {0}", x.HasValue);
            if (x.HasValue)
            {
                Console.WriteLine("Value:{0}", x.Value);
                Console.WriteLine("Explicit conversion:{0}", (int)x);
            }
            Console.WriteLine("GetValueOrDefault(): {0}", x.GetValueOrDefault());
            Console.WriteLine("GetValueOrDefault(10): {0}", x.GetValueOrDefault(10));
            Console.WriteLine("ToString(): \"{0}\"", x.ToString());
            Console.WriteLine("GetHashCode(): {0}", x.GetHashCode());
            Console.WriteLine();
        }
    }
}
