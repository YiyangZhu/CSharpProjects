using System;
using System.Collections.Generic;

namespace Chapter5
{
    public class InlineDelegate
    {
        public InlineDelegate()
        {
        }

        public static void Demo()
        {
            Action<int> printRoot = delegate (int number) {

                Console.WriteLine(Math.Sqrt(number));
            };

            Action<string> printReverse = delegate (string text)
            {
                char[] charArray = text.ToCharArray();
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    Console.Write(charArray[i]);
                }
                Console.WriteLine("");
            };

            Action<IList<double>> printMean = delegate (IList<double> list)
            {
                double sum = 0;
                foreach (double d in list)
                {
                    sum += d;
                }
                Console.WriteLine("The mean of the list is: " + sum / list.Count);
            };

            printRoot(2);
            printReverse("Hello World");
            printMean(new double[] { 1.5, 4.5, 5 });
        }

    }
}
