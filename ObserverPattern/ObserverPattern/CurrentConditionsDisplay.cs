using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: \n temperature {_temperature} F degrees " +
                $"and {_humidity} humidity \n");
        }

    }
}
