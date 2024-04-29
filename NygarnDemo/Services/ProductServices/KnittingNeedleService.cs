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

        public IEnumerable<KnittingNeedle> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<KnittingNeedle> filterList = new List<KnittingNeedle>();
            foreach (KnittingNeedle priceFilter in _knittingNeedle)
            {
                if ((minPrice == 0 && priceFilter.Price <= maxPrice) || (maxPrice == 0 && priceFilter.Price >= minPrice) || (priceFilter.Price >= minPrice && priceFilter.Price <= maxPrice))
                {
                    filterList.Add(priceFilter);
                }
            }
            return filterList;
        }

        public IEnumerable<KnittingNeedle> NameSearch(string str)
        {
            List<KnittingNeedle> nameSearch = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (string.IsNullOrEmpty(str) || needle.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(needle);
                }
            }
            return nameSearch;
        }
        public IEnumerable<KnittingNeedle> KnittingNeedleSizeFilter(int minSize = 0, int maxSize = int.MaxValue)
        {
            List<KnittingNeedle> needleSize = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (needle.Size >= minSize && needle.Size <= maxSize)
                {
                    needleSize.Add(needle);
                }
            }
            return needleSize;
        }
        public IEnumerable<KnittingNeedle> TypeSearch(string type)
        {
            List<KnittingNeedle> typeSearch = new List<KnittingNeedle>();
            foreach (KnittingNeedle needleType in _knittingNeedle)
            {
                if (string.IsNullOrEmpty(type) || type.ToLower() == type.ToLower())
                {
                    typeSearch.Add(needleType);
                }
            }
            return typeSearch;
        }

        public IEnumerable<KnittingNeedle> MaterialeSearch(string material)
        {
            List<KnittingNeedle> materialSearch = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (!string.IsNullOrEmpty(material) && needle.Materiale.ToLower() == material.ToLower())
                {
                    materialSearch.Add(needle);
                }
            }
            return materialSearch;
        }

    }
}