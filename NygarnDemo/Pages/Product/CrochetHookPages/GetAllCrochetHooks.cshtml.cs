using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        private ICrochetHookService _crochetHookService;

        public GetAllCrochetHooksModel(ICrochetHookService crochetHookService)
        {
            _crochetHookService = crochetHookService;
           
        }
        public List<Models.CrochetHook>? CrochetHooks { get; private set; } // her manglede Models.CrochetHooks og ikke listen af CrochetHookService liste

        public void OnGet()
        {
            CrochetHooks = _crochetHookService.GetCrochetHooks(); //ændret
        }
    }
}
