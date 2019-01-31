using System;
namespace DataStructures
{
    public class Lab1
    {
        public Lab1()
        {
        }

        public static void CarDemo()
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Silverado";
            myCar.Color = "Gray";
            Console.WriteLine($"My car is {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            myCar.Accelerate();
        }

        struct Car
        {
            public string Make;
            public string Model;
            public string Color;


            public void Accelerate()
            {
                Console.WriteLine("Vroom");
            }
        }
    }
}
