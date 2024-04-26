using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class KnittingNeedleService : IKnittingNeedleService
    {
        public List<KnittingNeedle> _knittingNeedle { get; set; }

        public KnittingNeedleService()
        {
            _knittingNeedle = MockKnittingNeedle.GetAllKnittingNeedles();
        }

        public List<KnittingNeedle> GetKnittingNeedles()
        {
            return _knittingNeedle;
        }

        //public IEnumerable<KnittingNeedle> KnittingNeedleFilter(int maxSize, int minSize = 0)
        //{
        //    List<KnittingNeedle> knittingFilterList = new List<KnittingNeedle>();
        //    foreach (KnittingNeedle knittingNeedle in _knittingNeedle)
        //    {
        //        if ((minSize == 0 && knittingNeedle.Size <= maxSize) || (maxSize == 0 && knittingNeedle.Size >= minSize) || (knittingNeedle.Size >= minSize && knittingNeedle.Size <= maxSize))
        //        {
        //            knittingFilterList.Add(knittingNeedle);
        //        }
        //    }
        //    return _knittingNeedle;
        //}

        //public IEnumerable<KnittingNeedle> NameSearch(string str)
        //{
        //    if (string.IsNullOrEmpty(str)) return _knittingNeedle;
        //    return from KnittingNeedle in _knittingNeedle where KnittingNeedle.Name.ToLower().Contains(str.ToLower()) select KnittingNeedle;
        //}
        public IEnumerable<KnittingNeedle> KnittingFilterList(int maxPrice, int minPrice = 0)
        {
            List<KnittingNeedle> knittingFilterList = new List<KnittingNeedle>();
            foreach (KnittingNeedle knittingNeedle in _knittingNeedle)
            {
                if ((minPrice == 0 && knittingNeedle.Price <= maxPrice) || (minPrice == 0 && knittingNeedle.Price >= maxPrice) || (knittingNeedle.Price == minPrice && knittingNeedle.Price <= maxPrice))
                {
                    knittingFilterList.Add(knittingNeedle);
                }
            } return knittingFilterList;
        }
     
    }
}