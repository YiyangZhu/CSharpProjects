using System;

namespace MSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine dm = new DrinksMachine();

            //use type inference, compile does not know type before initialization
            var dm2 = new DrinksMachine();
            dm.Make = "Fourth Coffee";
            dm.Model = "Beancrusher 3000";
            dm.Age = 2;
            dm.MakeEspresso();

            Console.WriteLine(dm.Location);

        }
    }
}
