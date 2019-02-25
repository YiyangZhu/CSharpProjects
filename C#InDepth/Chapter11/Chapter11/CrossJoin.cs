using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    public class CrossJoin
    {
        public CrossJoin()
        {
        }

        public static void Demo()
        {
            List<User> users = new List<User>()
            {
                new User("Tim Trotter", UserType.Tester),
                new User("Tara Tutu", UserType.Tester),
            };

            List<Project> projects = new List<Project>()
            {
                new Project("Skeety Media Player"),
                new Project("Skeety Talk"),
                new Project("Skeety Office")
            };

            var query = from user in users
                        from project in projects
                        select new { userName = user.Name, projectName = project.Name };

            foreach (var pair in query)
            {
                Console.WriteLine($"{pair.userName}/{pair.projectName}");
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

        public class Project
        {
            public string Name;

            public Project(string n)
            {
                this.Name = n;
            }
        }
    }
}
