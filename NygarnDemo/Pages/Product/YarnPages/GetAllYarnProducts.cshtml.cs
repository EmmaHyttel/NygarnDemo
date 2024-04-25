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

        public List<Yarn>? YarnProducts { get; private set; }

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public int MinPrice { get; set; }

        [BindProperty]
        public int MaxPrice { get; set; }

        [BindProperty]
        public string Color { get; set; }

        [BindProperty]
        public string Material { get; set; }

        [BindProperty]
        public string Brand { get; set; }

        [BindProperty]
        public string KnittingTension { get; set; }

        [BindProperty]
        public string Yardage { get; set; }

        [BindProperty]
        public string Needles { get; set; }

        [BindProperty]
        public string MachineWash { get; set; }


        public void OnGet()
        {
            YarnProducts = _yarnService.GetYarnProducts();
        }

        public IActionResult OnPostNameSearch()
        {
            YarnProducts = _yarnService.NameSearch(SearchString).ToList();
            return Page();
        }

        public IActionResult OnPostPriceFilter()
        {
            YarnProducts = _yarnService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }

    }
}
