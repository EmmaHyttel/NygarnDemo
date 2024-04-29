using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Pages.Product.CrochetHookPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class CrochetHookService : ICrochetHookService
    {
        public List<CrochetHook> CrochetHooks { get; set; }

        public CrochetHookService()
        {
            CrochetHooks = MockCrochetHook.GetAllCrochetHooks();
        }

        public List<CrochetHook> GetCrochetHooks()
        {
            return CrochetHooks;
        }

        public IEnumerable<CrochetHook> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<CrochetHook> filterList = new List<CrochetHook>();
            foreach (CrochetHook crochetHook in CrochetHooks)
            {
                if ((minPrice == 0 && crochetHook.Price <= maxPrice) || (maxPrice == 0 && crochetHook.Price >= minPrice) || (crochetHook.Price >= minPrice && crochetHook.Price <= maxPrice))
                {
                    filterList.Add(crochetHook);
                }
            }
            return filterList;
        }

        public IEnumerable<CrochetHook> NameSearch(string str)
        {
            List<CrochetHook> nameSearch = new List<CrochetHook>();
            foreach (CrochetHook crochet in CrochetHooks)
            {
                if (string.IsNullOrEmpty(str) || crochet.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(crochet);
                }
            }
            return nameSearch;
        }

        public IEnumerable<CrochetHook> CrochetHooksSizeFilter(int minSize = 0, int maxSize = int.MaxValue)
        {
            List<CrochetHook> crochetSize = new List<CrochetHook>();
            foreach (CrochetHook hooks in CrochetHooks)
            {
                if (hooks.Size >= minSize && hooks.Size <= maxSize)
                {
                    crochetSize.Add(hooks);
                }
            }
            return crochetSize;
        }
    }
}
