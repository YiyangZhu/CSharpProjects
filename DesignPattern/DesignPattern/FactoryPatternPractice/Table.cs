using System;
namespace DesignPattern.FactoryPatternPractice
{
    public class Table
    {
        public string Name;
        public string Color;

        public Table()
        {
            Name = "table";
            Color = "undecided";
        }

        public override string ToString()
        {
            return "A " + Name + " with " + Color + " color"; 
        }
    }
}
