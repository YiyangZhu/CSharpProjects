using System;
namespace DesignPattern.IteratorPatternPractice
{
    public class ClothesInventory : IInventory
    {
        public static string[] ClothItems;
        public static readonly int MAX_ITEMS = 6;
        public static int NumberOfItems;

        public ClothesInventory()
        {
            ClothItems = new string[MAX_ITEMS];

            AddItem("Dress");
            AddItem("Pant");
            AddItem("Jeans");
            AddItem("Pajama");
            AddItem("Sweater");
            AddItem("Hoddie");

        }

        public static void AddItem(string Name)
        {
            if(NumberOfItems < MAX_ITEMS)
            {
                ClothItems[NumberOfItems] = Name;
                NumberOfItems++;
            }
            else
            {
                Console.Error.WriteLine("Cloth Inventory is full!");
            }
        }

        public override string ToString()
        {
            return "Cloth Inventory";
        }

        public IIterator CreateInventory()
        {
            return new ClothesIterator(ClothItems);
        }
    }
}
