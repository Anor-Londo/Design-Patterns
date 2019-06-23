using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
            HeatIndex heatIndex = new HeatIndex(weatherData);

            weatherData.SetMeasurements(12, 43, 76);
            weatherData.SetMeasurements(43, 32, 63);
            weatherData.SetMeasurements(32, 43, 53);

            Console.ReadKey();
        }
    }
}
