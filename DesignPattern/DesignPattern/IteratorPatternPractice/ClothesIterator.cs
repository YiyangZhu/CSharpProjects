using System;
namespace DesignPattern.IteratorPatternPractice
{
    public class ClothesIterator : IIterator
    {
        public string[] Items;
        public int position = 0;

        public ClothesIterator(string[] i)
        {
            Items = i;
        }

        public bool HasNext()
        {
            if(position + 1 < Items.Length)
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
                string next = Items[position];
                position++;
                return next;
            }
            else
            {
                return null;
            }
        }
    }
}
