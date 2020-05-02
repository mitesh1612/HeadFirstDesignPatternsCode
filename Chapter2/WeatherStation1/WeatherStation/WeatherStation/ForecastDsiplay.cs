using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    public class ForecastDsiplay : Observer, DisplayElement
    {
        private float currentPressure = 29.2f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDsiplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }

        public void display()
        {
            Console.WriteLine("Forecast: ");
            if(currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            } else if(currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            } else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
