using System;

namespace MSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrinksMachine dm = new DrinksMachine();

            ////use type inference, compile does not know type before initialization
            //var dm2 = new DrinksMachine();
            //dm.Make = "Fourth Coffee";
            //dm.Model = "Beancrusher 3000";
            //dm.Age = 2;
            //dm.MakeEspresso();

            //Console.WriteLine(dm.Location);
            //DrinksMachine dm3 = new DrinksMachine(3);
            ////Console.WriteLine(dm2.Age);

            //Console.WriteLine(dm3.Age);
            //Console.WriteLine(dm3.Location);
            //Console.WriteLine(dm3.Make);

            //double weightInKilos = 80;
            //double weightInPounds = Conversions.KilosToPounds(weightInKilos);
            //Console.WriteLine(weightInPounds);

            //Console.WriteLine(Math.Pow(2, 8));

            var Car1 = new Car();

            Car1.Color = "white";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            Console.WriteLine($"This car is {Car1.Color},was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            var Car2 = new Car("Red",2008);

            Console.WriteLine($"This car is {Car2.Color}, and was built in {Car2.Year}");

            Console.WriteLine($"There are {Car.CountCars()} cars in total.");


        }
    }
}
