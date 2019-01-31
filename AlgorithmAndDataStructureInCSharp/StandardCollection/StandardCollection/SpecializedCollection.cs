using System;
using System.Collections.Generic;

namespace StandardCollection
{
    public class SpecializedCollection
    {
        public SpecializedCollection()
        {
        }

        struct Employee
        {
            public int empID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            public Employee(int e, string n, string d)
            {
                empID = e;
                Name = n;
                Department = d;
            }
        }

        public static void Demo()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { empID = 001, Name = "Tom", Department= "Sales"},
                new Employee() { empID = 024, Name = "Joan", Department= "HR"},
                new Employee() { empID = 023, Name = "Fred", Department= "Accounting" },
                new Employee() { empID = 040, Name = "Mike", Department= "Sales" },
            };

            Employee match = employees.Find((Employee p) => { return p.empID == 023; });
            Console.WriteLine($"Employee id is {match.empID}, name is {match.Name} and department is {match.Department}");

            Employee match2 = employees.Find((Employee p2) => { return p2.empID == 040; });
            Console.WriteLine($"Employee id is {match2.empID}, name is {match2.Name} and department is {match2.Department}");

            Employee match3 = employees.Find((Employee p3) => { return p3.empID == 045; });
            Console.WriteLine($"Employee id is {match3.empID}, name is {match3.Name} and department is {match3.Department}");


        }
    }
}
