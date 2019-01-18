using System;
namespace DesignPattern.ObserverPattern
{
    public class CurrentConditonsDisplay: IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject WeatherData;

        public CurrentConditonsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
