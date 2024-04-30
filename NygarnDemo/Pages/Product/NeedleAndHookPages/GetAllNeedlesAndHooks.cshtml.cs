using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Enums;


namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        
        private ICrochetHookService _crochetHookService;
        private IKnittingNeedleService _knittingNeedleService;

        public List<CrochetHook>? CrochetHooks { get; private set; }
        public List<KnittingNeedle>? KnittingNeedles { get; set; }

        [BindProperty]
        public string SearchString { get; set; }
       
        [BindProperty]
        public int Set { get; set; }
        
        [BindProperty]
        public int MaxPrice { get; set; }
        
        [BindProperty]
        public int MinPrice { get; set; }
   
        [BindProperty]
        public Size Size { get; set; }
        [BindProperty]
        public NeedleAndHookMaterial Material { get; set; }
        [BindProperty]
        public NeedleType Type { get; set; }

    



        public GetAllCrochetHooksModel(ICrochetHookService crochetHookService, IKnittingNeedleService knittingNeedleService)
        {
            _crochetHookService = crochetHookService;
            _knittingNeedleService = knittingNeedleService;
        }


        public void OnGet()
        {
            CrochetHooks = _crochetHookService.GetCrochetHooks();
            KnittingNeedles = _knittingNeedleService.GetKnittingNeedles();
        }

        public IActionResult OnPostNameSearch()
        {
            CrochetHooks = _crochetHookService.NameSearch(SearchString).ToList();
            KnittingNeedles = _knittingNeedleService.NameSearch(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostMaterialSearch()
        {
            CrochetHooks = _crochetHookService.HooksMaterialFilter(Material).ToList();
            KnittingNeedles = _knittingNeedleService.MaterialFilter(Material).ToList();
            return Page();
        }
        public IActionResult OnPostPriceFilter()
        {
            CrochetHooks = _crochetHookService.HooksPriceFilter(MaxPrice, MinPrice).ToList();
            KnittingNeedles = _knittingNeedleService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }

        public IActionResult OnPostSizeFilter()
        {
            CrochetHooks = _crochetHookService.CrochetHooksSizeFilter(Size).ToList();
            KnittingNeedles = _knittingNeedleService.NeedleSizeFilter(Size).ToList();

            return Page();
        }
        public IActionResult OnPostTypeFilter()
        {
            //CrochetHooks = _crochetHookService.HooksTypeFilter(Type).ToList();
            KnittingNeedles = _knittingNeedleService.NeedleTypeFilter(Type).ToList();

            return Page();
        }

    }
}
