using System;
using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    public class PancakeHouseMenu : IMenu
    {
        public List<string> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<string>();

            AddItem("Regular Pancake Breakfast");
            AddItem("Blueberry Pancakes");
        }

        public void AddItem(string Name)
        {
            menuItems.Add(Name);
        }

        public Iterator CreateIterator()
        {
            Iterator i = new PancakeHouseMenuIterator(menuItems);
            return i;
        }

        public override string ToString()
        {
            return "Pancake House Menu";
        }
    }
}
