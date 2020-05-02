using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if(temperature > maxTemp)
            {
                maxTemp = temperature;
            }
            else if(temperature < minTemp)
            {
                minTemp = temperature;
            }
            display();
        }

        public void display()
        {
            Console.WriteLine("Avg/Min/Max Temperature = " + (tempSum / numReadings) + "/" + minTemp + "/" + maxTemp);
        }
    }
}
