using NygarnDemo.Enums;
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
        public IEnumerable<KnittingNeedle> NeedleSizeFilter(Size size)
        {
            List<KnittingNeedle> needleSize = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (needle.Size == size)
                {
                    needleSize.Add(needle);
                }
            }
            return needleSize;
        }

        public IEnumerable<KnittingNeedle> NeedleTypeFilter(NeedleType type)
        {
            List<KnittingNeedle> NeedleTypeFilter = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (needle.Type == type)
                {
                    NeedleTypeFilter.Add(needle);
                }
            }
            return NeedleTypeFilter;
        }


        public IEnumerable<KnittingNeedle> MaterialFilter(NeedleAndHookMateriale material)
        {
            List<KnittingNeedle> NeedlesMateriale = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in _knittingNeedle)
            {
                if (needle.Materiale == material)
                {
                    NeedlesMateriale.Add(needle);
                }
            }

            return NeedlesMateriale;

        }
    }
}