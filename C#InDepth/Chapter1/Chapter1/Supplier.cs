using System;
using System.Collections.Generic;

namespace Chapter1
{
    public class Supplier
    {
        public Supplier()
        {
        }

        public int SupplierID { get; set; }
        public string Name { get; set; }

        Supplier(int id, string name)
        {
            this.SupplierID = id;
            this.Name = name;
        }

        public static List<Supplier> GetSampleSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            suppliers.Add(new Supplier(001, "AAA"));
            suppliers.Add(new Supplier(002, "BBB"));
            suppliers.Add(new Supplier(003, "CCC"));
            suppliers.Add(new Supplier(004, "DDD"));
            suppliers.Add(new Supplier(005, "EEE"));
            suppliers.Add(new Supplier(006, "FFF"));
            return suppliers;

        }


    }
}
