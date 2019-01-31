using System;
using System.Collections;

namespace StandardCollection
{
    public class SimpleCollection
    {
        public SimpleCollection()
        {
        }

        struct Coffee
        {
            public int Strength
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public string NationOfOrigin
            {
                get;
                set;
            }

            public Coffee(int s, string t, string n)
            {
                Strength = s;
                Type = t;
                NationOfOrigin = n;
            }
        }

        public static void Demo()
        {
            ArrayList beverages = new ArrayList();
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");
            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];

            foreach(Coffee c in beverages)
            {
                Console.WriteLine($"Coffee strength is {c.Strength}, type of bean is {c.Type} and nation of origin is: " +
                    $"{c.NationOfOrigin}.");
            }
            Console.WriteLine("");

            Hashtable ingredients = new Hashtable();
            ingredients.Add("Café au Lait", "Coffee, Milk");
            ingredients.Add("Café Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");

            foreach(string key in ingredients.Keys)
            {
                Console.WriteLine($"Coffee name is {key}, and its ingredients are {ingredients[key]}");
            }
        }
    }
}
