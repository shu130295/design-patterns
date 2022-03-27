using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private List<Observer> observers;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void notifyObservers()
        {
            observers.ForEach(observer => observer.update());
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.measurementsChanged();
        }

        public void measurementsChanged()
        {
            this.notifyObservers();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }
    }
}
