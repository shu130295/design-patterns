using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current coditions: " + temperature + "F degrees and " + humidity + "% humidity.");
        }

        public void update()
        {
            this.temperature = weatherData.getTemperature();
            this.humidity = weatherData.getHumidity();
            this.display();
        }
    }
}
