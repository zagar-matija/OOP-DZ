using System;
using System.Collections.Generic;
using System.Text;

namespace dz3_class_lib
{
    public class BiasedGenerator : IRandomGenerator
    {
        private Random generator;
        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }
        public double Generate(double min, double max)
        {
            int x = generator.Next(1, 4);
            if(x < 3)
                return generator.NextDouble() * ((max - min)/2) + min;
            else
                return generator.NextDouble() * ((max - min) / 2) + min + (max - min);
        }
    }
}
