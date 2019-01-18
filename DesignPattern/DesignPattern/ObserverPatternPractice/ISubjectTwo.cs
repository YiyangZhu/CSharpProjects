using System;
namespace DesignPattern.ObserverPatternPractice
{
    public interface ISubjectTwo
    {
        void RegisterObserver(IObserverTwo o);
        void RemoveObserver(IObserverTwo o);
        void NotifyObserver();
    }
}
