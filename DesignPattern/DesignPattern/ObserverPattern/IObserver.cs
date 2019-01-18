using System;
namespace DesignPattern.ObserverPattern
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
