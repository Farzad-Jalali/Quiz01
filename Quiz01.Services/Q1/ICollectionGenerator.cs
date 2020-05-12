using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz01.Services.Q1
{
    public interface ICollectionGenerator : INumberGenerator
    {
        ICollection<int> NextCollection(int index);
    }
}
