using System;

namespace Chapter9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Demo();

            Demo2();

            Demo3();

            Film.Demo();
                      
            ExpressionTree.Demo();

            ExpressionTree.Demo2();

            ExpressionTree.Demo3();

            TypeInference.Demo();

            TypeInference.Demo2();

            TypeInference.Demo3();

            TypeInference.Demo4();

            TypeInference.Demo5();
            */
            TypeInference.Demo6();




        }

        public static void Demo()
        {
            Func<string, int> returnLength;
            returnLength = delegate (string text) { return text.Length; };

            Console.WriteLine(returnLength("Hello World"));
        }

        public static void Demo2()
        {
            Func<string, int> returnLength;
            returnLength = (string text) => { return text.Length; };

            Console.WriteLine(returnLength("Hello YY"));
        }

        public static void Demo3()
        {
            Func<string, int> returnLength;
            returnLength = text => text.Length;

            Console.WriteLine(returnLength("Hello Youngkey"));
        }
    }
}
