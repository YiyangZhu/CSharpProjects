using System;
using System.Collections.Generic;

namespace Chapter1
{
    //strongly typed collection
    public class ProductTwo
    {
        string name;
        decimal? price;
        public decimal? Price
        {
            get { return price; }
            private set { price = value; }
        }
        public string Name 
        { 
            get { return name; }
            private set { name = value; }
        }

        public int SupplierID { get; set; }

        public ProductTwo(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public ProductTwo(string name, decimal price, int supplierID)
        {
            this.name = name;
            this.price = price;
            this.SupplierID = supplierID;
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

        public static List<ProductTwo> GetSampleProductsTwo()
        {
            List<ProductTwo> list = new List<ProductTwo>();
            list.Add(new ProductTwo("West Side Story", 9.99m, 001));
            list.Add(new ProductTwo("Assassins", 14.99m, 002));
            list.Add(new ProductTwo("Frogs", 13.99m, 003));
            list.Add(new ProductTwo("Sweeney Todd", 10.99m, 004));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
