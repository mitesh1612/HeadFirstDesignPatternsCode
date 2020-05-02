using System;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
            ForecastDsiplay forecastDisplay = new ForecastDsiplay(weatherData);
            HeatIndexDisplay hiDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);

        }
    }
}
