using System;
using System.Collections.Generic;
using System.Linq;


namespace Chapter11
{
    public class CastInLinq
    {
        public CastInLinq()
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

            var query = from user in users
                        orderby user.Name.Length
                        select user.Name;
            foreach(var name in query)
            {
                Console.WriteLine(name);
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
                        let length = user.Name.Length
                        orderby length
                        select new { Name = user.Name, Length = length };

            foreach(var entry in query)
            {
                Console.WriteLine($"{entry.Name}: {entry.Length}");
            }


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
}
