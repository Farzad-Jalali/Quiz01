using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz01.Services.Q1
{
    public class RatioCalculator : IRatioCalculator
    {
        public decimal GetRatio2sTo1s(IList<ICollection<int>> records)
        {
            decimal ones = records.Select(clc => clc.Where(number => number == 1).Count()).Sum(count => count);
            decimal twos = records.Select(clc => clc.Where(number => number == 2).Count()).Sum(count => count);

            return ones / twos;
        }
    }
}
