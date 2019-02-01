using System;
using System.Collections.Generic;

namespace Chapter1
{
    //strongly typed collection
    public class ProductTwo
    {
        string name;
        public string Name 
        { 
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price 
        { 
            get { return price; }
            private set { price = value; }
        }

        public ProductTwo(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static void Demo()
        {
            List<ProductTwo> list = GetSampleProducts();
            foreach (ProductTwo product in list)
            {
                Console.WriteLine($"The product is {product}");
            }
        }

        public static List<ProductTwo> GetSampleProducts()
        {
            List<ProductTwo> list = new List<ProductTwo>();
            list.Add(new ProductTwo("West Side Story", 9.99m));
            list.Add(new ProductTwo("Assassins", 14.99m));
            list.Add(new ProductTwo("Frogs", 13.99m));
            list.Add(new ProductTwo("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
