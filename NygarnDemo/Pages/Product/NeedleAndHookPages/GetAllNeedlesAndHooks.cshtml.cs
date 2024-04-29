using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        
        private ICrochetHookService _crochetHookService;
        private IKnittingNeedleService _knittingNeedleService;
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
        public List<Models.CrochetHook>? CrochetHooks { get; private set; }
        public List<Models.KnittingNeedle>? KnittingNeedles { get; set; }

        public void OnGet()
        {
            CrochetHooks = _crochetHookService.GetCrochetHooks();
            KnittingNeedles = _knittingNeedleService.GetKnittingNeedles();
        }
        public IActionResult OnPostCrochetHookPriceFilter()
        {
            CrochetHooks = _crochetHookService.CrochetHooksPriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }

        public IActionResult OnPostCrochetHooksSizeFilter()
        {
            CrochetHooks = _crochetHookService.CrochetHooksSizeFilter(MaxSize, MinSize).ToList();
            return Page();
        }


    }
}
