using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        private ICrochetHookService _crochetHookService;
        //private IKnittingNeedleService _knittingNeedleService;


        public GetAllCrochetHooksModel(ICrochetHookService crochetHookService /*IKnittingNeedleService knittingNeedleService*/)
        {
            _crochetHookService = crochetHookService;
            //_knittingNeedleService = knittingNeedleService;
        }
        public List<Models.CrochetHook>? CrochetHooks { get; private set; }
        //public List<Models.KnittingNeedle>? KnittingNeedles { get; set; }

        public void OnGet()
        {
            CrochetHooks = _crochetHookService.GetCrochetHooks();
        }
        //public void OnGetKnittingNeedles()
        //{
        //    KnittingNeedles = _knittingNeedleService.GetKnittingNeedles();
        //}
    }
}
