using System;
using System.Collections.Generic;

namespace DesignPattern.FactoryPattern
{
    public class Pizza
    {
        public string Name;
        public string Sauce;
        public List<string> Toppings = new List<string>();

        public string GetName()
        {
            return Name;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing " + Name);
        }

        public override string ToString()
        {
            return "This is a " + Name + ", with " + Sauce;
        }
    }
}
