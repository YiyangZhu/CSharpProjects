using System;
namespace DataStructures
{
    public class ExtendStructDemo
    {
        public ExtendStructDemo()
        {
        }

        public struct Coffee
        {
            private int strength;
            public string bean;

            public int Strength
            {
                get { return strength; }
                set
                {
                    if (value < 1)
                    {
                        strength = 1;
                    }
                    else if (value > 5)
                    {
                        strength = 5;
                    }
                    else
                    {
                        strength = value;

                    }
                }
            }

            // This is a read-only property. 
            public int NationOfOrigin
            {
                get { return NationOfOrigin; }
            }
            // This is a write-only property. 

            public string Bean
            {
                set { bean = value; }
            }
        }

        public struct Menu
        {
            public string[] beverages;
            public Menu(string bev1, string bev2)
            {
                beverages = new string[] { "Americano", "Café au Lait", "Café Macchiato", "Cappuccino", "Espresso" };
            }
        }

        public static void ExtendStructDemo_()
        {
            Coffee coffee1 = new Coffee();
            // The following code invokes the set accessor. 
            coffee1.Strength = 3; 
            // The following code invokes the get accessor. 
            int coffeeStrength = coffee1.Strength;
            Menu myMenu = new Menu();
            string firstDrink = myMenu.beverages[0];
            Console.WriteLine("Beverage at index 0 in beverages in menu is {0}", firstDrink);

        }
    }
}
