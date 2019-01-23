using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    public class SimpleArray
    {
        public string[] GroceryList;
        public SimpleArray()
        {
            GroceryList = new string[4] { "", "", "", "" };

        }
        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and xxx";
        }

        public void JustTest()
        {
            var multi = new int[3, 4]
            {
                {0,1,2,3},
                {4,5,6,7},
                {8,9,10,11}
            };
            Console.Write(multi[2, 3]);
            var awesomeSauces = new List<string>();
            awesomeSauces.Add("Cholula");
            awesomeSauces.Add("Tobasco");
            //sort alphabetically
            awesomeSauces.Sort();


        }
    }
}
