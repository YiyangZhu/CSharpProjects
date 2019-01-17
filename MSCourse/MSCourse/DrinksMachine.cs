using System;
namespace MSCourse
{
    public class DrinksMachine
    {
        private string _location;
        private int _age;
        private string _make;

        public static int count;

        public static int CountDrinkMachines()
        {
            return count;

        }

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (value != null)
                {
                    _location = value;
                }
            }
        }


        public string Model { get; set; }


        public void MakeCappuccino()
        {

        }

        public void MakeEspresso()
        {
            Console.WriteLine("Cappuccino is made.");
        }


        //public event OutOfBeansHandler OutOfBeans;

        public DrinksMachine()
        {

        }

        public DrinksMachine(int age)
        {
            this.Age = age;
        }

        //Auto-implemented properties
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public string Location1 { get => _location; set => _location = value; }
        public int Age { get => _age; set => _age = value; }
        public string Make { get => _make; set => _make = value; }
    }

    //public partial class DrinksMachine
    //{

    //}
}
