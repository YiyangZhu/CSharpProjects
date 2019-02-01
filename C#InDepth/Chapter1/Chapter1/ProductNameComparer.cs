using System;
using System.Collections;

namespace Chapter1
{
    public class ProductNameComparer : IComparer
    {
        public ProductNameComparer()
        {
        }

        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }

        public static void Demo()
        {
            ArrayList products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());
            foreach(Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static void QDemo()
        {
            ArrayList products = Product.GetSampleProducts();
            foreach(Product p in products)
            {
                if(p.Price > 10m)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
