using Quiz01.Services.Q1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q2
{
    public class DiceRoller : IDiceRoller
    {
        public int RollTheDice()
        {
            var engin = new NumberGenerator(1, 6);
            return engin.NextNumber();
        }
    }
}