using System;
using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    public class PancakeHouseMenuIterator : Iterator
    {
        List<string> items;
        public int position = 0;

        public PancakeHouseMenuIterator(List<string> i)
        {
            this.items = i;
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
                return null;
            }

        }

        public bool HasNext()
        {
            if(position + 1 <= items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
