using System;
namespace DesignPattern.IteratorPattern
{
    public class DinerMenu : IMenu
    {
        public static readonly int MAX_ITEMS = 6;
        public int NumberOfItems = 0;
        public string[] MenuItems;

        public DinerMenu()
        {
            MenuItems = new string[MAX_ITEMS];
            AddItem("Soup");
            AddItem("Pasta");
            AddItem("Beef");
            AddItem("Chicken");
            AddItem("Lamb");
            AddItem("Rice");
        }

        public void AddItem(string Name)
        {
            if(NumberOfItems < MAX_ITEMS)
            {
                MenuItems[NumberOfItems] = Name;
                NumberOfItems++;
            }
            else
            {
                Console.Error.WriteLine("Sorry,menu is full! Can't add item to menu.");
            }
        }

        public Iterator CreateIterator()
        {
            Iterator i = new DinerMenuIterator(MenuItems);
            return i;
        }

        public override string ToString()
        {
            return "Diner Menu";
        }
    }
}
