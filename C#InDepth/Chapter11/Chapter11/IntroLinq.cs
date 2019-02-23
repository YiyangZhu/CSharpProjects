using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    public class IntroLinq
    {
        public IntroLinq()
        {
        }

        public static void Demo()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(30, "Linda"));
            people.Add(new Person(22, "Jeff"));
            people.Add(new Person(7, "Youngkey"));

            var adultNames = from person in people
                             where person.Age >= 18
                             select person.Name;

            foreach (string n in adultNames)
            {
                Console.WriteLine(n);
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

            var query = from user in users
                        select user;

            foreach (var user in query)
            {
                Console.WriteLine(user);
            }
        }

        public class Person
        {
            public int Age;
            public string Name;

            public Person(int a, string n)
            {
                this.Age = a;
                this.Name = n;
            }
        }

        public class User
        {
            string Name;
            UserType userType;


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
    }
}
