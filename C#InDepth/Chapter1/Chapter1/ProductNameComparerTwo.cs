using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter1
{
    public class ProductNameComparerTwo : IComparer<ProductTwo>
    {
        public ProductNameComparerTwo()
        {
        }

        public int Compare(ProductTwo x, ProductTwo y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public static void Demo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();
            products.Sort(new ProductNameComparerTwo());
            foreach (ProductTwo p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static void DemoTwo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();
            products.Sort(delegate (ProductTwo x, ProductTwo y) { return x.Name.CompareTo(y.Name); });

            foreach (ProductTwo p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static void DemoThree()
        {
            List<ProductThree> products = ProductThree.GetSampleProducts();
            products.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (ProductThree p in products)
            {
                Console.WriteLine(p);
            }
        }

        public static void DemoFour()
        {


            List<ProductThree> products = ProductThree.GetSampleProducts();
            List<ProductThree> newList = products.
            
            /*
            foreach (ProductThree p in products.OrderBy(p1 => p1.Name))//Ask
            {
                Console.WriteLine(p);
            }
            */
        }
    }

}
