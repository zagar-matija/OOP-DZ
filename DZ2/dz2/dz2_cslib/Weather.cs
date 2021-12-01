using System;

namespace dz2
{
    public class Weather
    {
        private double temperature;
        private double windSpeed;
        private double humidity;

        public Weather()
        {
            temperature = 0;
            windSpeed = 0;
            humidity = 0;
        }

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
        }

        public void SetTemperature(double temperature) { this.temperature = temperature; }
        public void SetHumidity(double humidity) { this.humidity = humidity; }
        public void SetWindSpeed(double windSpeed) { this.windSpeed = windSpeed; }

        public double GetTemperature() { return temperature; }
        public double GetHumidity() { return humidity; }
        public double GetWindSpeed() { return windSpeed; }

        public double CalculateFeelsLikeTemperature()
        {
            return -8.78469475556 + 1.61139411 * temperature + 2.33854883889 * humidity + -0.14611605 * temperature * humidity
                     - 0.012308094 * Math.Pow(temperature, 2) + -0.0164248277778 * Math.Pow(humidity, 2)
                        + 0.002211732 * Math.Pow(temperature, 2) * humidity + 0.00072546 * Math.Pow(humidity, 2) * temperature
                             - 0.000003582 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);
        }

        public double CalculateWindChill()
        {
            double windChill = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
            if (temperature <= 10 && windSpeed > 4.8)
                return windChill;
            else
                return 0;
        }

        public string GetAsString()
        {
            return $"T={temperature}°C, w={windSpeed}km/h, h={humidity}%";
        }

        public static bool operator>(Weather A, Weather B)
        {
            return A.GetTemperature() > B.GetTemperature();
        }
        public static bool operator <(Weather A, Weather B)
        {
            return A.GetTemperature() < B.GetTemperature();
        }
        public static bool operator ==(Weather A, Weather B)
        {
            return A.GetTemperature() == B.GetTemperature();
        }
        public static bool operator !=(Weather A, Weather B)
        {
            return !(A==B);
        }
        public static bool operator >(Weather A, double B)
        {
            return A.GetTemperature() > B;
        }
        public static bool operator <(Weather A, double B)
        {
            return A.GetTemperature() < B;
        }
    }
}
