using System;
namespace DataStructures
{
    public class Lab2
    {
        public Lab2()
        {
        }

        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        public static void EnumDemo()
        {
            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine($"Sun = {x}");
            Console.WriteLine($"Fri = {y}");
            Console.WriteLine(Days.Thu);
        }
    }
}
