using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services;
using NygarnDemo.Services.DbServices;
using NygarnDemo.Services.Interfaces;


namespace NygarnDemo.Services.ProductServices
{
    public class CrochetHookService : ICrochetHookService
    {
		private CrochetHookDbService _crochetHookDbService;

		public List<Models.CrochetHook> CrochetHooks { get; set; }

		public CrochetHookService(CrochetHookDbService dbService)
		{
            //CrochetHooks = MockCrochetHook.GetAllCrochetHooks();
            _crochetHookDbService = dbService;
            CrochetHooks = _crochetHookDbService.GetCrochetHooks().Result.ToList();
            _crochetHookDbService.SaveCrochetHooks(CrochetHooks);
        }

		public CrochetHookService()
        {
            CrochetHooks = MockCrochetHook.GetAllCrochetHooks();
        }

        public List<CrochetHook> GetCrochetHooks()
        {
            return CrochetHooks;
        }

        public IEnumerable<CrochetHook> HooksPriceFilter(int maxPrice, int minPrice = 0)
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

        public IEnumerable<CrochetHook> CrochetHooksSizeFilter(Size size)
        {
            List<CrochetHook> hooksSize = new List<CrochetHook>();
            foreach (CrochetHook crochetHook in CrochetHooks)
            {
                if (crochetHook.Size == size)
                {
                    hooksSize.Add(crochetHook);
                }
            }
            return hooksSize;
        }

        public IEnumerable<CrochetHook> HooksMaterialFilter(NeedleAndHookMaterial material)
        {
            List<CrochetHook> HooksMaterialFilter = new List<CrochetHook>();
            foreach (CrochetHook hooks in CrochetHooks)
            {
                if (hooks.Material == material)
                {
                    HooksMaterialFilter.Add(hooks);
                }
            }
            return HooksMaterialFilter;
        }
		public async Task AddCrochetHookAsync(CrochetHook crochetHook)
		{
			await _crochetHookDbService.AddCrochetHook(crochetHook);
		}

        public async Task<CrochetHook> DeleteHookAsync(int? Id)
        {
            CrochetHook Deletehook = CrochetHooks.FirstOrDefault(hook => hook.ProductId == Id);
            if (Deletehook != null)
            {
                CrochetHooks.Remove(Deletehook);
            }
            return Deletehook;
        }

        public List<CrochetHook> GetFilteredCrochetHooks(string searchString, decimal? minPrice, decimal? maxPrice,Size? size, NeedleAndHookMaterial? material)
        {
            var hooks = GetCrochetHooks();

            if (!string.IsNullOrEmpty(searchString))
            {
                hooks = hooks.Where(h => h.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (minPrice.HasValue)
            {
                hooks = hooks.Where(h => h.Price >= minPrice.Value).ToList();
            }
            if (maxPrice.HasValue)
            {
                hooks = hooks.Where(h => h.Price <= maxPrice.Value).ToList();
            }
            if (size.HasValue)
            {
                hooks = hooks.Where(h => h.Size == size).ToList();
            }
            if (material.HasValue)
            {
                hooks = hooks.Where(h => h.Material == material).ToList();
            }
    
            return hooks;

        }
    }
}