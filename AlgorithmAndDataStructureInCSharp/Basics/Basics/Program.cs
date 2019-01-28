using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBase = 2;
            int exp = 16;
            int result = 1;
            while(exp > 0)
            {
                result *= numBase;
                exp--;
            }
            Console.WriteLine($"Result is {result}");
        }
    }
}
