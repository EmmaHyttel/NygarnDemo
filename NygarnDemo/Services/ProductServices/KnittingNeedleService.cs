using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class KnittingNeedleService : IKnittingNeedleService
    {

        public List<KnittingNeedle> KnittingNeedle { get; set; }

        public KnittingNeedleService()
        {
            KnittingNeedle = MockKnittingNeedle.GetAllKnittingNeedles();
        }

        public List<KnittingNeedle> GetKnittingNeedles()
        {
            return KnittingNeedle;
        }

        public IEnumerable<KnittingNeedle> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<KnittingNeedle> filterList = new List<KnittingNeedle>();
            foreach (KnittingNeedle priceFilter in KnittingNeedle)
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
            foreach (KnittingNeedle needle in KnittingNeedle)
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
            foreach (KnittingNeedle needle in KnittingNeedle)
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
            foreach (KnittingNeedle needle in KnittingNeedle)
            {
                if (needle.Type == type)
                {
                    NeedleTypeFilter.Add(needle);
                }
            }
            return NeedleTypeFilter;
        }
        public IEnumerable<KnittingNeedle> MaterialFilter(NeedleAndHookMaterial material)
        {
            List<KnittingNeedle> NeedlesMateriale = new List<KnittingNeedle>();
            foreach (KnittingNeedle needle in KnittingNeedle)
            {
                if (needle.Material == material)
                {
                    NeedlesMateriale.Add(needle);
                }
            }

            return NeedlesMateriale;

        }
    }
}