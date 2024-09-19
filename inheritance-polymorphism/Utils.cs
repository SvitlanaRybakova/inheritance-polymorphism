using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    public class Utils
    {
        static public double GetDoubleRandom(double minValue, double maxValue)
        {
            Random random = new Random();
            double result = minValue + (random.NextDouble() * (maxValue - minValue));
            return Math.Round(result, 2);
        }
    }
}