using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter1
{
    public class HandleNullValue
    {
        public HandleNullValue()
        {
        }

        public static void Demo()
        {
            List<ProductThree> products = ProductThree.GetSampleProducts();

            foreach(ProductThree product in products.Where(p => p.Price == null))
            {
                Console.WriteLine(product.Name);
            }

        }

        public static void DemoTwo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();
            products.FindAll(delegate (ProductTwo p) { return p.Price == null; }).ForEach(Console.WriteLine);//Ask Ke
        }

        public static void DemoThree()
        {
            List<ProductFour> products = ProductFour.GetSampleProducts();

            foreach (ProductFour product in products.Where(p => p.Price == null))
            {
                Console.WriteLine(product.Name);
            }

        }
    }
}
