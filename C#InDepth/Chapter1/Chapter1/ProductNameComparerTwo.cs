using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
            /*
            foreach (ProductThree p in products.OrderBy(p1 => p1.Name))//Ask
            {
                Console.WriteLine(p);
            }
            */
        }

        public static void QDemo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();

            Predicate<ProductTwo> test = delegate (ProductTwo p) { return p.Price > 10m; };
            List<ProductTwo> matches = products.FindAll(test);

            Action<ProductTwo> print = Console.WriteLine;
            matches.ForEach(print);
        }

        public static void QDemoTwo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();

            products.FindAll(delegate (ProductTwo p) { return p.Price > 10; }).ForEach(Console.WriteLine);
        }

        public static void QDemoThree()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();

            foreach(ProductTwo product in products.Where(p => p.Price > 10))//need revise, stackoverflow error
            {
                Console.WriteLine(product);
            }

        }

    }

}
