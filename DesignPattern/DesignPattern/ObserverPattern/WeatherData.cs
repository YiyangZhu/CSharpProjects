using System;
using System.Collections.Generic;

namespace DesignPattern.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public float Temperature { get => temperature; set => temperature = value; }
        public float Humidity { get => humidity; set => humidity = value; }
        public float Pressure { get => pressure; set => pressure = value; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

    }
}
