using System;
namespace DataStructures
{
    public class EnumDemo
    {
        public EnumDemo()
        {
        }

        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum DayTwo { Sunday = 2, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public static void EnumDemo_()
        {
            var names = Enum.GetNames(typeof(Day)); //GetNames() returns string
            var values = Enum.GetValues(typeof(Day)); //GetValues() returns an array that contains the values of the constants in that type
            foreach (string s in names)//way 1 to iterate an enum
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("");

            foreach(Day d in values)//way 2 to iterate an enum
            {
                Console.Write(d + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("The second element in enum Day (starting index is 0) is {0}",(Day)2);
            Console.WriteLine("The second element in enum DayTwo (starting index is 2) is {0}", (DayTwo)2);
            Console.WriteLine("The value for Sunday in enum Day is {0}", (int)Day.Sunday);
            Console.WriteLine("The value for Sunday in enum DayTwo is {0}", (int)DayTwo.Sunday);
            //set a variable by name
            Day favoriteDay = Day.Friday;
            Console.WriteLine("My favorite day is {0}.", favoriteDay);
            //set a variable by value
            Day keFavoriteDay = (Day)6;
            Console.WriteLine("Ke favorite day is {0}.", keFavoriteDay);

        }
    }
}
