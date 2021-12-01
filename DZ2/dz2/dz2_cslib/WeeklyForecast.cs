using System;
using System.Collections.Generic;
using System.Text;

namespace dz2
{
    public class WeeklyForecast
    {
        public WeeklyForecast(DailyForecast[] dailyPrognoses)
        {
            this.dailyForecasts = dailyPrognoses; 
        }

        public DailyForecast[] dailyForecasts { get; private set; }

        public string GetAsString()
        {
            string forecast = ""; 
            foreach(DailyForecast i in dailyForecasts)
            {
                forecast += i.GetAsString() + "\n";
            }
            return forecast;
        }

        public DailyForecast this[int index]
        {
            get { return dailyForecasts[index]; }
        }

        public double GetMaxTemperature()
        {
            double max = dailyForecasts[0].weather.GetTemperature();
            foreach(DailyForecast daily in dailyForecasts)
            {
                if (daily.weather > max)
                    max = daily.weather.GetTemperature();
            }
            return max;
        }
    }
}
