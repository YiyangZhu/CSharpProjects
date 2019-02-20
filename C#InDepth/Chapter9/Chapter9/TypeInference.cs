using System;
namespace Chapter9
{
    public class TypeInference
    {
        public TypeInference()
        {
        }

        public static void PrintConvertedValue<TInput, TOutput>(TInput input, Converter<TInput, TOutput> converter)
        {
            Console.WriteLine(converter(input));
        }

        public static void Demo()
        {
            PrintConvertedValue("I'm a string", x => x.Length);
        }

        public delegate T MyFunc<T>();

        public static void WriteResult<T>(MyFunc<T> function)
        {
            Console.WriteLine(function());
        }

        public static void Demo2()
        {
            WriteResult(delegate { return 5; });
        }

        public static void Demo3()
        {
            WriteResult(delegate
            {
                if (DateTime.Now.Hour < 12)
                {
                    return 10;
                }
                else
                {
                    return new object();
                }
            });

        }

        public static void Demo4()
        {
            PrintType(1, new object());
        }

        public static void PrintType<T>(T first, T second)
        {
            Console.WriteLine(typeof(T));
        }

        public static void Demo5()
        {
            ConvertTwice("Another string", text => text.Length, length => Math.Sqrt(length));
        }

        static void ConvertTwice<TInput, TMiddle, TOutput>(TInput input, Converter<TInput,TMiddle> firstConversion, Converter<TMiddle,TOutput> secondConversion)
        {
            TMiddle middle = firstConversion(input);
            TOutput output = secondConversion(middle);
            Console.WriteLine(output);
        }

        static void Execute(Func<int> action)
        {
            Console.WriteLine("action returns an int: " + action());
        }

        static void Execute(Func<double> action)
        {
            Console.WriteLine("action returns a double: " + action());
        }

        public static void Demo6()
        {
            Execute(() => 1);
            Execute(() => 5.2);
        }
    }
}
