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
            */
            ExpressionTree.Demo3();



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
