using System;
using System.Collections.Generic;
using System.Text;

namespace dz2
{
    public class DailyForecast
    {
        public DailyForecast(DateTime date, Weather weather)
        {
            this.date = date;
            this.weather = weather;
        }

        public DateTime date { get; private set; } 
        public Weather weather { get; private set; }

        public string GetAsString()
        {
            return $"{date.ToString()}"+ ": " + weather.GetAsString();
        }
        
    }
}
