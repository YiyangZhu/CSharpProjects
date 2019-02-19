using System;
namespace Chapter7
{
    //use static before class, and do not need a constructor
    public static class StringHelper
    {
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
