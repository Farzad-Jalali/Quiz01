using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Quiz01.Services.Q1
{
    public class CollectionGenerator : ICollectionGenerator
    {
        private readonly INumberGenerator _numberGenerator;

        public CollectionGenerator(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }
        public ICollection<int> NextCollection(int index)
        {
            ICollection<int> result = new Collection<int>();
            int lastInstance;

            do
            {
                lastInstance = this.NextNumber();
                result.Add(lastInstance);
            }
            while (result.Count < index && lastInstance != 2);

            return result;
        }

        public int NextNumber()
        {
            return _numberGenerator.NextNumber();
        }
    }
}
