using System;
namespace DataStructures
{
    public class ReverseCharacters
    {
        public ReverseCharacters()
        {
        }

        public static void Demo()
        {
            string string1 = "abcad";
            string result1 = "aacbd";
            Test(Reversal(string1), result1);
            string string2 = "a0b c1d";
            string result2 = "a1c b0d";
            Test(Reversal(string2), result2);

        }

        public static void Test(string s, string r)
        {
            Console.WriteLine($"expected result is {r}, actual result is {s}");
        }

        public static string Reversal(string s)
        {
            if(s == null || s.Length <= 1)
            {
                return s;
            }
            char[] input = s.ToCharArray();
            int n = s.Length;
            char[] newCharArray = new char[n];
            newCharArray[0] = input[0];
            newCharArray[n - 1] = input[n - 1];
            for (int i = 1; i < n - 1; i++)
            {
                newCharArray[i] = input[n - 1 - i];
            }
            return new string(newCharArray);
        }
    }
}
