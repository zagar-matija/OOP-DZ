using System;
using System.Collections.Generic;
using System.Text;

namespace dz3_class_lib
{
    public class WeatherGenerator
    {
        private IRandomGenerator generator;
        private double minT;
        private double maxT;
        private double minH;
        private double maxH;
        private double minWS;
        private double maxWS;

        public WeatherGenerator( double minT,
                double maxT, double minH, double maxH, double minWS, double maxWS, IRandomGenerator generator)
        {
            this.generator = generator;
            this.minT = minT;
            this.maxT = maxT;
            this.minH = minH;
            this.maxH = maxH;
            this.minWS = minWS;
            this.maxWS = maxWS;
        }
        public Weather Generate()
        {
            double temperature = generator.Generate(minT, maxT);
            double humidity = generator.Generate(minH, maxH);
            double windspeed = generator.Generate(minWS, maxWS);
            return new Weather(temperature, humidity, windspeed);
        }
        public void SetGenerator(IRandomGenerator generator)
        {
            this.generator = generator;
        }
    }
}
