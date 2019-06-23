using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class HeatIndex : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public HeatIndex(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"\n HeatIndex is {(_temperature + _humidity)/2.05} \n");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
