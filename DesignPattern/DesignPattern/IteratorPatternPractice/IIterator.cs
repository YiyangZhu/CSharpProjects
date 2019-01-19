using System;
namespace DesignPattern.IteratorPatternPractice
{
    public interface IIterator
    {
        bool HasNext();
        string Next();
    }
}
