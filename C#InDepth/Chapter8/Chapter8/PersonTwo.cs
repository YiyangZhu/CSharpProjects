using System;
using System.Collections.Generic;

namespace Chapter8
{
    public class PersonTwo
    {
        public int Age { get; set; }
        public string Name { get; set; }

        List<PersonTwo> friends = new List<PersonTwo>();
        public List<PersonTwo> Friends { get { return friends; } }

        Location home = new Location();

        public Location Home { get { return Home; } }

        public PersonTwo()
        {

        }

        public PersonTwo(string name)
        {
            Name = name;
        }

        public void Demo()
        {
            PersonTwo tom1 = new PersonTwo();
            tom1.Name = "Tom";
            tom1.Age = 9;

            PersonTwo tom2 = new PersonTwo("Tom");
            tom2.Age = 9;

            PersonTwo tom3 = new PersonTwo() { Name = "Tom", Age = 9 };
            PersonTwo tom4 = new PersonTwo() { Name = "Tom", Age = 9 };
            PersonTwo tom5 = new PersonTwo("Tom") { Age = 9 };

            PersonTwo[] family = new PersonTwo[]
            {
                new PersonTwo{Name = "Holly", Age = 36},
                new PersonTwo{Name = "Jon", Age = 36},
                new PersonTwo{Name = "Tom", Age = 9},
                new PersonTwo{Name = "William", Age = 6},
                new PersonTwo{Name = "Robin", Age = 6}
            };

            PersonTwo tom = new PersonTwo("Tom");
            tom.Age = 9;
            tom.Home.Country = "UK";
            tom.Home.Town = "Reading";

            PersonTwo tom0 = new PersonTwo("Tom")
            {
                Age = 9,
                home = { Country = "UK", Town = "Reading" }
            };

            List<string> names = new List<string>();
            names.Add("Holly");
            names.Add("Jon");
            names.Add("Tom");
            names.Add("Robin");
            names.Add("William");

            Dictionary<string, int> nameAgeMap = new Dictionary<string, int>
            {
                {"Holly",36},
                {"Jon",36},
                {"Tom",9}
            };

            PersonTwo tom6 = new PersonTwo
            {
                Name = "Tom",
                Age = 9,
                Home = { Town = "Reading", Country = "UK" },
                Friends =
                {
                    new PersonTwo{ Name = "Alberto"},
                    new PersonTwo("Max"),
                    new PersonTwo{ Name = "Zak", Age = 7},
                    new PersonTwo("Ben"),
                    new PersonTwo("Alice")
                }

            };


        }

        public static void DemoTwo()
        {
            var tom = new { Name = "Tom", Age = 9 };
            var holly = new { Name = "Holly", Age = 36 };
            var jon = new { Name = "Jon", Age = 36 };

            Console.WriteLine("{0} is {1} years old", jon.Name, jon.Age);

            var family = new[]
            {
                new { Name = "Holly", Age = 36 },
                new { Name = "Jon", Age = 36 },
                new { Name = "Tom", Age = 9 },
                new { Name = "Robin", Age = 6 },
                new { Name = "William", Age = 6 }
            };

            int totalAge = 0;
            foreach(var person in family)
            {
                totalAge += person.Age;
            }
            Console.WriteLine("Total age: {0}", totalAge);
        }

        public class Location
        {
            public string Country { get; set; }
            public string Town { get; set; }
        }

    }


}
