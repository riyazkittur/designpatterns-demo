using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Startup
    {
        public static void Main()
        {
            WeatherData weatherData;
            CurrentConditionsDisplay currentConditionsDisplay;
            ForcastDisplay forcastDisplay;
            StatisticsDisplay statisticsDisplay;
            HeatIndexDisplay heatIndexDisplay;

            weatherData = new WeatherData();
            currentConditionsDisplay =
                new CurrentConditionsDisplay(weatherData);
            forcastDisplay = new ForcastDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(81, 63, 31.2f);
            Console.WriteLine(forcastDisplay.Display());
            Console.WriteLine(heatIndexDisplay.Display());


        }
    }

