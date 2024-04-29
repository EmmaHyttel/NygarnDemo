using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        
        private ICrochetHookService _crochetHookService;
        private IKnittingNeedleService _knittingNeedleService;

        public List<Models.CrochetHook>? CrochetHooks { get; private set; }
        public List<Models.KnittingNeedle>? KnittingNeedles { get; set; }

        [BindProperty]
        public string SearchString { get; set; }
       
        [BindProperty]
        public int Set { get; set; }
        [BindProperty]
        public int MaxPrice { get; set; }
        [BindProperty]
        public int MinPrice { get; set; }
        [BindProperty]
        public int MaxSize { get; set; }
        [BindProperty]
        public int MinSize { get; set; }



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
            return Page();
        }
        public IActionResult OnPostPriceFilter()
        {
            CrochetHooks = _crochetHookService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }

        public IActionResult OnPostCrochetHooksSizeFilter()
        {
            CrochetHooks = _crochetHookService.CrochetHooksSizeFilter(MaxSize, MinSize).ToList();
            return Page();
        }

        public IActionResult OnPostMaterialSearch(string materiale)
        {
            KnittingNeedles = _knittingNeedleService.MaterialeSearch(materiale).ToList();
            return Page();
        }
    }
}
