using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
//using System.Data.Linq; //NOT AVAILABLE, NEED REVISE LATER

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

        public static void DemoThree()
        {
            XDocument doc = XDocument.Load("/Users/yiyangemmazhu/CSharpProjects/C#InDepth/Chapter1/data.xml");
            var filtered = from p in doc.Descendants("Product")
                           join s in doc.Descendants("Supplier")
                           on (int)p.Attribute("SupplierID")
                           equals (int)s.Attribute("SupplierID")
                           where (decimal)p.Attribute("Price") > 10
                           orderby (string)s.Attribute("Name"),
                           (string)p.Attribute("Name")
                           select new
                           {
                               SupplierName = (string)s.Attribute("Name"),
                               ProductName = (string)p.Attribute("Name")
                           };
            foreach(var v in filtered)
            {
                Console.WriteLine("Supplier={0}; Product={1}", v.SupplierName, v.ProductName);
            }
        }

        public static void DemoFour()
        {/*
            using (LinqDemoDataContext db = new LinqDemoDataContext())
            {
                var filtered = from p in db.Products
                               join s in db.Suppliers
                                  on p.SupplierID equals s.SupplierID
                               where p.Price > 10
                               orderby s.Name, p.Name
                               select new { SupplierName = s.Name, ProductName = p.Name };
                foreach (var v in filtered)
                {
                    Console.WriteLine("Supplier={0}; Product={1}",
                                      v.SupplierName, v.ProductName);
                }
            }
            */
            //NEED REVISE LATER

        }
    }
}
