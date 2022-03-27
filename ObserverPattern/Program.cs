// See https://aka.ms/new-console-template for more information
using ObserverPattern;

WeatherData weatherData = new WeatherData();

CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);

weatherData.setMeasurements(90, 25, 35);
weatherData.setMeasurements(95, 20, 30);
weatherData.setMeasurements(100, 15, 40);
