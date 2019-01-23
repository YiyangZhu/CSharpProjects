using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public class AwesomeSauce
    {
        public List<string> Sauces { get; set; }
        public bool IsSauceAwesome(string sauce)
        {
            return Sauces.Contains(sauce);
        }

        public void ToTest()
        {
            var listOfNumbers = new int[5] { 1, 3, 5, 7, 9 };
            listOfNumbers.Sum();
            listOfNumbers.Average();
            listOfNumbers.Where(item => item >= 3);
            var dictionaryWords = new Dictionary<string, string>();
            dictionaryWords.Add("var", "shorthand for variable");
            //dictionaryWords["var"];
            //dictionaryWords.Count;
            Console.Write(dictionaryWords.Keys);
            dictionaryWords.Add("var", "this is a dupe");
        }
    }
}
