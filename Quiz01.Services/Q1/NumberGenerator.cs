using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q1
{
    public class NumberGenerator : INumberGenerator
    {
        private readonly int _min;
        private readonly int _max;

        public NumberGenerator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public int NextNumber()
        {
            Random r = new Random();
            return r.Next(_min, _max + 1);
        }
    }
}
