using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace dz2
{
    public class ForecastUtilities
    {
        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            Weather largestWindChill = weathers[0];

            for (int i = 1; i < weathers.Length; i++)
            {
                if (largestWindChill.CalculateWindChill() < weathers[i].CalculateWindChill())
                {
                    largestWindChill = weathers[i];
                }
            }
            return largestWindChill;
        }

        public static DailyForecast Parse(string line)
        {
            string[] formatted = new string[4];
            formatted=line.Split(",");
            DateTime date = DateTime.ParseExact(formatted[0], "G", new CultureInfo("es-ES"));
            Weather weather=new Weather(Convert.ToDouble( formatted[1], CultureInfo.InvariantCulture), Convert.ToDouble(formatted[3], CultureInfo.InvariantCulture),
                Convert.ToDouble(formatted[2], CultureInfo.InvariantCulture));
            return new DailyForecast(date, weather);
        }
    }
}
