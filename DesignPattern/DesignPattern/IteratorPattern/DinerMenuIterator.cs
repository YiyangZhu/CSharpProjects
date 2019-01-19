using System;
namespace DesignPattern.IteratorPattern
{
    public class DinerMenuIterator : Iterator
    {
        public string[] items;
        public int position = 0;

        public DinerMenuIterator(string[] i)
        {
            this.items = i;
        }

        public bool HasNext()
        {
            if(position + 1 <= items.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Next()
        {
            if (HasNext())
            {
                string menuItem = items[position];
                position++;
                return menuItem;
            }
            else
            {
                Console.Error.WriteLine("no next item!");
                return null;
            }
        }
    }
}
