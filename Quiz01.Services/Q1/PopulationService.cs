using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Quiz01.Services.Q1
{
    public class PopulationService : IPopulationService
    {
        private readonly IRatioCalculator _ratioCalculator;
        private readonly ICollectionGenerator _collectionGenerator;


        public PopulationService(IRatioCalculator ratioCalculator, ICollectionGenerator collectionGenerator)
        {
            _ratioCalculator = ratioCalculator;
            _collectionGenerator = collectionGenerator;
        }

        /// <summary>
        /// for te sake of the coding question , I put this method but , if you really beind the sence 
        /// we are using the impmentation of INumberGenerator
        /// </summary>
        /// <returns></returns>
        public int GetRandom2s1s()
        {
            return _collectionGenerator.NextNumber();
        }


        /// <summary>
        /// for te sake of the coding question , I put this method but , if you really beind the sence 
        /// we are using the impmentation of ICollectionGenerator
        /// </summary>
        /// <returns></returns>
        public ICollection<int> NextCollection(int index)
        {
            return _collectionGenerator.NextCollection(index);
        }


        public decimal RatioPerformanceCheck(int times, int index)
        {
            IList<ICollection<int>> records = new List<ICollection<int>>();

            while (times-- > 0)
            {
                records.Add(_collectionGenerator.NextCollection(index));
            }
            var ratio = _ratioCalculator.GetRatio2sTo1s(records: records);


            return ratio;
        }
    }
}