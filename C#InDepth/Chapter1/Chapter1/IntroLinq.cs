using System;
using System.Linq;
using System.Collections.Generic;

namespace Chapter1
{
    public class IntroLinq
    {
        public IntroLinq()
        {
        }

        public static void Demo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProducts();
            var filtered = from ProductTwo p in products
                           where p.Price > 10
                           select p;
            foreach(ProductTwo p in filtered)
            {
                Console.WriteLine(p);
            }
        }

        public static void DemoTwo()
        {
            List<ProductTwo> products = ProductTwo.GetSampleProductsTwo();
            List<Supplier> suppliers = Supplier.GetSampleSuppliers();

            var filtered = from p in products
                           join s in suppliers
                           on p.SupplierID equals s.SupplierID
                           where p.Price > 10
                           orderby s.Name, p.Name
                           select new { SupplierName = s.Name, ProductName = p.Name };
            foreach(var v in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1}", v.SupplierName, v.ProductName);
            }

        }
    }
}
