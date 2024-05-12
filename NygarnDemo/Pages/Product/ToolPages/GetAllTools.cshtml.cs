using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.ToolPages
{
    public class GetAllToolsModel : PageModel
    {
        private IToolService _toolService;

        public List<Tool>? Tools { get; private set; }

        [BindProperty]
        public string Size { get; set; }  // string er valgt, istedet for enum, da der forskellige str på ting? 

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public int MaxPrice { get; set; }

        [BindProperty]
        public int MinPrice { get; set; }

        [BindProperty]
        public string Brand { get; set; }

        [BindProperty]
        public string Type { get; set; }

        public GetAllToolsModel(IToolService toolService)
        {
            _toolService = toolService;
        }

        public void OnGet()
        {
            Tools = _toolService.GetToolsProducts();
        }

        public IActionResult OnPostPriceFilter()
        {
            Tools = _toolService.PriceFilter(MaxPrice, MinPrice).ToList();
            return Page();
        }

        public IActionResult OnPostBrandFilter()
        {
            Tools = _toolService.BrandFilter(Brand).ToList();
            return Page();

        }

        public IActionResult OnPostNameSearch()
        {

            Tools = _toolService.NameSearch(SearchString).ToList();
            return Page();

        }
        public IActionResult OnPostTypeFilter()
        {
            Tools = _toolService.TypeSearch(Type).ToList();
            return Page();

        }

        public IActionResult OnPostSizeFilter()
        {
            Tools = _toolService.SizeFilter(Size).ToList();
            return Page();

        }
    }
}
