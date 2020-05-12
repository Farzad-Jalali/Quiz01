using Quiz01.Services.Q1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q2
{
    public class CustomerPlaysCounter : ICustomerPlaysCounter
    {
        public int GetPlaysCountRandomly(int minGames, int maxGames)
        {
            var engin = new NumberGenerator(minGames, maxGames);
            return engin.NextNumber();
        }
    }
}