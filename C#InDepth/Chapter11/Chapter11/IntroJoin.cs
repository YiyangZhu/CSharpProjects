using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    public class IntroJoin
    {
        public IntroJoin()
        {

        }

        public static void Demo()
        {
            List<User> users = new List<User>()
            {
                new User("Tim Trotter", UserType.Tester),
                new User("Tara Tutu", UserType.Tester),
                new User("Deborah Denton", UserType.Developer),
                new User("Darren Dahlia", UserType.Developer),
                new User("Mary Malcop", UserType.Manager),
                new User("Colin Carton", UserType.Customer)

            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Tim Trotter", 3000),
                new Employee("Tara Tutu", 3500),
                new Employee("Deborah Denton", 2800),
                new Employee("Darren Dahlia", 3100),
                new Employee("Mary Malcop", 2900)
            };

            var query = from user in users
                        join employee in employees
                        on user.Name equals employee.Name
                        select new { Name = employee.Name, Type = user.userType, Salary = employee.Salary };

            foreach (var entry in query)
            {
                Console.WriteLine($"{entry.Name}, {entry.Type}, {entry.Salary}");
            }
        }

        public static void Demo2()
        {
            List<User> users = new List<User>()
            {
                new User("Tim Trotter", UserType.Tester),
                new User("Tara Tutu", UserType.Tester),
                new User("Deborah Denton", UserType.Developer),
                new User("Darren Dahlia", UserType.Developer),
                new User("Mary Malcop", UserType.Manager),
                new User("Colin Carton", UserType.Customer)

            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Tim Trotter", 3000),
                new Employee("Tara Tutu", 3500),
                new Employee("Deborah Denton", 2800),
                new Employee("Darren Dahlia", 3100),
                new Employee("Mary Malcop", 2900)
            };

            var query = from user in users
                        join employee in employees
                        on user.Name equals employee.Name
                        into groupedUser
                        select new { User1 = user, Users = groupedUser };

            foreach (var entry in query)
            {
                foreach (var u in entry.Users)
                {
                    Console.WriteLine("{0}", u.Salary);
                }
            }

            var query2 = from user in users
                         join employee in employees
                         on user.Name equals employee.Name
                         into joined
                         select new { Count = joined.Count()};

            foreach(var grouped in query2)
            {
                Console.WriteLine($"{grouped.Count}");
            }
        }

        public class User
        {
            public string Name;
            public UserType userType;


            public User(string n, UserType u)
            {
                this.Name = n;
                this.userType = u;
            }


            public override string ToString()
            {
                return Name + " (" + userType + ")";
            }
        }

        public enum UserType
        {
            Customer,
            Developer,
            Tester,
            Manager
        }

        public class Employee
        {
            public string Name;
            public int Salary;

            public Employee(string n, int s)
            {
                this.Name = n;
                this.Salary = s;
            }


        }

    }


}
