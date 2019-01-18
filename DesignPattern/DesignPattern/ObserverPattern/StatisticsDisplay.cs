using System;
using System.Collections.Generic;

namespace DesignPattern.ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject WeatherData;
        private List<float> tempList;
        private List<float> humiList;
        private float averageTemp;
        private float averageHumi;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
            tempList = new List<float>();
            humiList = new List<float>();
        }

        public void Display()
        {
            Console.WriteLine("Statistics: average temperature is " + averageTemp + "F degrees and average humidity is " + averageHumi + "%.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Calculate();
            Display();
        }

        public void Calculate()
        {
            tempList.Add(temperature);
            humiList.Add(humidity);
            float tempTotal = 0;
            foreach(float t in tempList)
            {
                tempTotal += t;
            }

            float humiTotal = 0;
            foreach (float t in humiList)
            {
                humiTotal += t;
            }

            averageTemp = tempTotal / tempList.Count;
            averageHumi = humiTotal / humiList.Count;
        }
    }
}
