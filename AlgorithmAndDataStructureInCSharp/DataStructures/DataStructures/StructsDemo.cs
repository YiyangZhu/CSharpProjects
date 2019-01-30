using System;
namespace DataStructures
{
    public class StructsDemo
    {
        public StructsDemo()
        {
        }

        public static void Definition()
        {
            /*
            A struct is a programming construct that you can use to define
            custom types. Structs are essentially lightweight data structures
            that represent related pieces of information as a single item.
            For example:
            1. A struct named Point might consist of fields to represent an
            x-coordinate and a y-coordinate.
            2. A struct named Circle might consist of fields to represent an
            x-coordinate, a y-coordinate, and a radius.
            3. A struct named Color might consist of fields to represent a red
            component, a green component, and a blue component.
            Most of the built-in types in Visual C#, such as int, bool, and char,
            are defined by structs. You can use structs to create your own types
            that behave like built-in types.
             */
            Coffee coffee1 = new Coffee()
            {
                Strength = 3,
                Bean = "Arabica",
                CountryOfOrigin = "Kenya"
            }; // This initialization does not have object initialization can be simplified reminder
            Coffee coffee2 = new Coffee();//reminder: object initialization can be simplified.
            coffee2.Strength = 4;
            coffee2.Bean = "Arabica";
            coffee2.CountryOfOrigin = "Kenya";
            Coffee coffee3 = new Coffee(1, "Arabica", "Kenya");
                      
        }

        public struct Coffee
        {

            public int Strength;
            public string Bean;
            public string CountryOfOrigin;

            public Coffee(int strength, string bean, string countryOfOrigin)
            {
                Strength = strength;
                Bean = bean;
                CountryOfOrigin = countryOfOrigin;
            }
        }
    }
}
