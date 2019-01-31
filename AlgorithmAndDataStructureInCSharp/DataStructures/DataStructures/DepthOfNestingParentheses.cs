using System;
using System.Collections;

namespace DataStructures
{
    public class DepthOfNestingParentheses
    {
        public DepthOfNestingParentheses()
        {
        }

        public static void Demo()
        {
            string input1 = "a(())b()";
            int er1 = 2;
            Test(er1,FindDepth(input1));

            string input2 = "(()1()";
            int er2 = 0;
            Test(er2, FindDepth(input2));
        }

        public static void Test(int er, int ar)
        {
            Console.WriteLine($"the expected result is {er}, the actual result is {ar}");
        }

        public static int FindDepth(string input)
        {
            char[] charArray = input.ToCharArray();
            int count = 0;
            int maxCount = 0;
            Stack stack = new Stack();
            for(int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i] == '(')
                {
                    if(count != 0)
                    {
                        maxCount = Math.Max(count, maxCount);
                        count = 0;
                    }
                    stack.Push('(');
                } else if (charArray[i] == ')')
                {
                    if(stack.Count != 0)
                    {
                        count++;
                        stack.Pop();
                    }
                }
            }
            if(stack.Count != 0)
            {
                maxCount = 0;
            }
            return maxCount;
        }
    }
}
