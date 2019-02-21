using System;
namespace Chapter10
{
    public static class NullUtil
    {
        public static bool IsNull(this object x)
        {
            return x == null;
        }

        public static void Demo()
        {
            object y = null;
            Console.WriteLine("object y = null; y.IsNull() = " + y.IsNull());
            Console.WriteLine("object y = null; string.IsNullOrEmpty((string)y) =  " + IsNullOrEmpty((string)y));

            y = new object();
            Console.WriteLine("y = new object(); y.IsNull() = " + y.IsNull());
            try
            {
                Console.WriteLine("y = new object(); string.IsNullOrEmpty((string)y) =  " + IsNullOrEmpty((string)y));
            } catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("y = new object(); string.IsNullOrEmpty((string)y) = unable to cast object to string");
            }


        }

        public static bool IsNullOrEmpty(this string text)
        {
            return string.IsNullOrEmpty(text);
        }
    }
}
