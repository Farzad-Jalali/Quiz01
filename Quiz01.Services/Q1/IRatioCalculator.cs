using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q1
{
    public interface IRatioCalculator
    {
        decimal GetRatio2sTo1s(IList<ICollection<int>> records);
    }
}
