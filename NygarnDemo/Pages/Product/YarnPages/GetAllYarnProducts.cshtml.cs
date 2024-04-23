using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;
using NygarnDemo.Models;

namespace NygarnDemo.Pages.Product.YarnPages
{
    public class GetAllYarnProductsModel : PageModel
    {
       
        public List<Yarn> _yarnProducts { get; private set; }

        public void OnGet()
        {
            MockYarn.GetMockYarn();
        }
    }
}
