using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter10
{
    public class Company
    {
        public List<Department> Departments = new List<Department>();

        public class Department
        {
            public String Name = "";
            public List<Employee> Employees = new List<Employee>();

        }

        public class Employee
        {
            public long Salary;
            public String EmployeeName;

            public Employee(long s, string n)
            {
                Salary = s;
                EmployeeName = n;
            }
        }

        public Company()
        {
            Department ITDepart = new Department();
            ITDepart.Name = "IT";
            Console.WriteLine(ITDepart.Name);
            Console.WriteLine(ITDepart.Employees);

            ITDepart.Employees.Add(new Employee(3500, "Martin"));
            ITDepart.Employees.Add(new Employee(5500, "Peter"));
            Departments.Add(ITDepart);

            Department SalesDepart = new Department();
            SalesDepart.Name = "Sales";

            SalesDepart.Employees.Add(new Employee(7000, "Jenny"));
            Departments.Add(SalesDepart);
        }

        public void Demo()
        {
            var collection = Departments
                .Select(dept => new { Name = dept.Name, Cost = dept.Employees.Sum(p => p.Salary) })
                .OrderBy(dept => dept.Cost);

            foreach(var v in collection)
            {
                Console.WriteLine(v);
            }

        }
    }
}
