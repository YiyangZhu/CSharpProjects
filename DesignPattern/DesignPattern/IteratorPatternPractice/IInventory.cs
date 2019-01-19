using System;
namespace DesignPattern.IteratorPatternPractice
{
    public interface IInventory
    {
        IIterator CreateInventory();
    }
}
