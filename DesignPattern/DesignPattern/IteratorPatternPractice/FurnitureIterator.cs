using System;
using System.Collections.Generic;

namespace DesignPattern.IteratorPatternPractice
{
    public class FurnitureIterator : IIterator
    {
        public List<string> FurnitureList;
        public int position;

        public FurnitureIterator(List<string> f)
        {
            FurnitureList = f;
            position = 0;
        }

        public bool HasNext()
        {
            if(position + 1 < FurnitureList.Count)
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
                string next = FurnitureList[position];
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
