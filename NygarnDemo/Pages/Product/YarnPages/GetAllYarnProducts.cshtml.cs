using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using System.Security.Claims;

namespace NygarnDemo.Pages.Product.YarnPages
{
    public class GetAllYarnProductsModel : PageModel
    {
        private readonly NygarnDbContext _dbContext;
        private IYarnService _yarnService;

        public bool IsAdmin { get; private set; }


        public GetAllYarnProductsModel(IYarnService yarnService, NygarnDbContext yarnContext)
        {
            _yarnService = yarnService;
            _dbContext = yarnContext;
        }

        public IList<Yarn>? YarnProducts { get; private set; }

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
        public string Brand { get; set; }

        [BindProperty]
        public string KnittingTension { get; set; }

        [BindProperty]
        public string Yardage { get; set; }

        [BindProperty]
        public Size Size { get; set; }

        [BindProperty]
        public bool MachineWash { get; set; }

        [BindProperty]
        public Color ColorFilter { get; set; }

        [BindProperty]
        public Material MaterialFilter { get; set; }

        [BindProperty]
        public string BrandFilter { get; set; }

        [BindProperty]
        public string YardageFilter { get; set; }

        [BindProperty]
        public string SizeFilter { get; set; }

        [BindProperty]
        public bool MachinewashFilter { get; set; }

        public async Task OnGetAsync()
        {
            //YarnProducts = _yarnService.GetYarnProducts();
            YarnProducts = await _dbContext.Yarn.ToListAsync();
            IsAdmin = HttpContext.User.HasClaim(c => c.Type == ClaimTypes.Role && c.Value == "admin");
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

        //public IActionResult OnPostMachinewashFilter()
        //{
        //    YarnProducts = _yarnService.MachinewashFilter(MachineWash).ToList();
        //    return Page();
        //}

    }
}
