using System;
namespace MSCourse
{
    public class DrinksMachine
    {
        private string _location;
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

        public string Make { get; set; }
        public string Model { get; set; }
        public int Age { get; set; }

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
    }

    //public partial class DrinksMachine
    //{

    //}
}
