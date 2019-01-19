using System;
using System.Collections.Generic;

namespace DesignPattern.IteratorPatternPractice
{
	public class FurnitureInventory : IInventory
	{
        public static List<string> FurnitureItems;

        public FurnitureInventory()
        {
            FurnitureItems = new List<string>();

            AddItem("Table");
            AddItem("Chair");
            AddItem("Bed");
            AddItem("Sofa");
            AddItem("TV Stand");
            AddItem("Cabinet");

        }

        public static void AddItem(string Name)
        {
            FurnitureItems.Add(Name);
        }

        public override string ToString()
        {
            return "Furniture Inventory";
        }

        public IIterator CreateInventory()
        {
            return new FurnitureIterator(FurnitureItems);
        }
    }
}
