
using System;
namespace Chapter7
{
//sealed defines restrictions in class; once define a class as sealed, this class cannot be inherited
    public sealed class NonStaticStringHelper
    {
        private NonStaticStringHelper()
        {

        }

        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
