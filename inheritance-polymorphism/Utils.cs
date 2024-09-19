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
            return minValue + (random.NextDouble() * (maxValue - minValue));
        }
    }
}