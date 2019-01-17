using System;
namespace MSCourse
{
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = Mileage;
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }

    }
}
