using Quiz01.Services.Q1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.XUnitTest
{
    public class FakeNumber1Generator : INumberGenerator
    {
        public int NextNumber()
        {
            return 1;
        }
    }
}
