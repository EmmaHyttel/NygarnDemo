using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.YarnPages
{
    public class GetAllYarnProductsModel : PageModel
    {

        private IYarnService _yarnService;

        public GetAllYarnProductsModel(IYarnService yarnService)
        {
            _yarnService = yarnService;
        }

        public List<Yarn> YarnProducts { get; private set; }

        public void OnGet()
        {
            YarnProducts = _yarnService.GetYarnProducts();
        }

    }
}
