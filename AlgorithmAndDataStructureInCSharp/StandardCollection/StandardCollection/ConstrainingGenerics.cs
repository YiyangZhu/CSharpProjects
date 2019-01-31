using System;
using System.Collections.Generic;

namespace StandardCollection
{
    public class ConstrainingGenerics
    {
        public ConstrainingGenerics()
        {
        }

        //public class CustomList<T> where T: IBeverage,, IComparable<T>, new()
        //{

        //}

        public static void Demo()
        {
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";
            var coffeeBeverages = new List<String>();
            coffeeBeverages.Add(s1);
            coffeeBeverages.Add(s2);
            coffeeBeverages.Add(s3);
            coffeeBeverages.Add(s4);
            coffeeBeverages.Add(s5);
            coffeeBeverages.Sort();
            foreach(string coffeeBeverage in coffeeBeverages)
            {
                Console.WriteLine(coffeeBeverage);
            }

            var coffeeCodes = new Dictionary<string, string>();
            coffeeCodes.Add("CAL", "Café Au Lait");
            coffeeCodes.Add("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add("ER", "Espresso Romano");
            coffeeCodes.Add("RM", "Raspberry Mocha");
            coffeeCodes.Add("IC", "Iced Coffee");

            Console.WriteLine($"The value associated with the key \"CAL\" is {coffeeCodes["CAL"]}");

            Console.WriteLine();
            string csmValue = "";
            if(coffeeCodes.TryGetValue("CSM", out csmValue)) // TryGetValue(key, out stringVariableName)
            {
                Console.WriteLine($"The value associated with the key \"CSM\" is {csmValue}");
            }
            else
            {
                Console.WriteLine("The key \"CSM\" was not found");
            }
            coffeeCodes["IC"] = "Instant Coffee";
        }
    }
}
