using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

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
        public Color Color { get; set; }

        [BindProperty]
        public Material Material { get; set; }

        [BindProperty]
        public Brand Brand { get; set; }

        [BindProperty]
        public KnittigTension KnittingTension { get; set; }

        [BindProperty]
        public Yardage Yardage { get; set; }

        [BindProperty]
        public Size Size { get; set; }

        [BindProperty]
        public Machinewash MachineWash { get; set; }

        [BindProperty]
        public Color ColorFilter { get; set; }

        [BindProperty]
        public Material MaterialFilter { get; set; }

        [BindProperty]
        public Brand BrandFilter { get; set; }

        [BindProperty]
        public KnittigTension KnittingTensionFilter { get; set; }

        [BindProperty]
        public Yardage YardageFilter { get; set; }

        [BindProperty]
        public Yardage SizeFilter { get; set; }

        [BindProperty]
        public Machinewash MachinewashFilter { get; set; }

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

        public IActionResult OnPostColorFilter()
        {
            YarnProducts = _yarnService.ColorFilter(Color).ToList();
            return Page();
        }

        public IActionResult OnPostMaterialFilter()
        {
            YarnProducts = _yarnService.MaterialFilter(Material).ToList();
            return Page();
        }

        public IActionResult OnPostBrandFilter()
        {
            YarnProducts = _yarnService.BrandFilter(Brand).ToList();
            return Page();
        }

        public IActionResult OnPostKnittingTensionFilter()
        {
            YarnProducts = _yarnService.KnittingTensionFilter(KnittingTension).ToList();
            return Page();
        }

        public IActionResult OnPostYardageFilter()
        {
            YarnProducts = _yarnService.YardageFilter(Yardage).ToList();
            return Page();
        }

        public IActionResult OnPostSizeFilter()
        {
            YarnProducts = _yarnService.SizeFilter(Size).ToList();
            return Page();
        }

        public IActionResult OnPostMachinewashFilter()
        {
            YarnProducts = _yarnService.MachinewashFilter(MachineWash).ToList();
            return Page();
        }

    }
}
