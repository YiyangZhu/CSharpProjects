using System;
using System.Collections.Generic;

namespace Chapter1
{
    public class ProductFour
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public ProductFour()
        {
        }

        public ProductFour(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<ProductFour> GetSampleProducts()
        {
            return new List<ProductFour>
            {
                new ProductFour(name: "Water", price: 0.99m),
                new ProductFour(name: "Coke", price: 1.35m),
                new ProductFour(name: "Juice", price:2.99m)
            };
        }

        public static void Demo()
        {
            List<ProductFour> list = GetSampleProducts();
            foreach(ProductFour p in list)
            {
                Console.WriteLine(p);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }

    }
}
