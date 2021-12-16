using System;
using System.Collections.Generic;
using System.Text;

namespace dz3_class_lib
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

        public override string ToString()
        {
            return $"{date.ToString()}"+ ": " + weather.ToString();
        }
        
    }
}
