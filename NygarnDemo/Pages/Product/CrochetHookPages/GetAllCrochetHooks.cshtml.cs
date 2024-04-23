using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;

namespace NygarnDemo.Pages.Product.CrochetHookPages
{
    public class GetAllCrochetHooksModel : PageModel
    {
        public List<MockCrochetHook> mockCrochetHooks;
        public void OnGet()
        {
            MockCrochetHook.GetAllCrocketHooks();
        }
    }
}
