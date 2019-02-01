using System;
using System.Collections.Generic;

namespace Chapter1
{
    public class ProductThree
    {
        public string Name { get; private set; }
        decimal? price;
        public decimal? Price
        {
            get { return price; }
            private set { price = value; }
        }

        public ProductThree(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        ProductThree() { }

        public static List<ProductThree> GetSampleProducts()
        {
            return new List<ProductThree>
            {
                new ProductThree { Name = "West Side Story", Price = 9.99m },
                new ProductThree { Name = "Assassins", Price = 14.99m },
                new ProductThree { Name = "Frogs", Price = 13.99m },
                new ProductThree { Name = "Sweeney Todd", Price = 10.99m }
            };
        }

        public static void Demo()
        {
            List<ProductThree> list = GetSampleProducts();
            foreach(ProductThree p in list)
            {
                Console.WriteLine(p);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
