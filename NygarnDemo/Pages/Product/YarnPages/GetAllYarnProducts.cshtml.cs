using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.User;
using System.Security.Claims;

namespace NygarnDemo.Pages.Product.YarnPages
{
    public class GetAllYarnProductsModel : PageModel
    {
        private readonly NygarnDbContext _dbContext;
        private IYarnService _yarnService;
        private IUserService _userService;

        public bool IsAdmin { get; private set; }


        public GetAllYarnProductsModel(IYarnService yarnService, NygarnDbContext yarnContext, IUserService userService)
        {
            _yarnService = yarnService;
            _dbContext = yarnContext;
            _userService = userService;
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

        [BindProperty]
        public int SelectedProductId { get; set; }

        public async Task OnGetAsync()
        {
            //YarnProducts = _yarnService.GetYarnProducts();
            YarnProducts = await _dbContext.Yarn.ToListAsync();
            IsAdmin = HttpContext.User.HasClaim(c => c.Type == ClaimTypes.Role && c.Value == "admin");
        }

        public async Task<IActionResult> OnPostNameSearch()
        {
            YarnProducts =  _yarnService.NameSearch(SearchString).Result.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPostPriceFilter()
        {
            YarnProducts = await _yarnService.PriceFilter(MaxPrice, MinPrice);
            return Page();
        }

        public async Task<IActionResult> OnPostColorFilter()
        {
            YarnProducts = await _yarnService.ColorFilter(Color);
            return Page();
        }

        public async Task<IActionResult> OnPostMaterialFilter()
        {
            YarnProducts = await _yarnService.MaterialFilter(Material);
            return Page();
        }

        public async Task<IActionResult> OnPostBrandFilter()
        {
            YarnProducts = await _yarnService.BrandFilter(Brand);
            return Page();
        }

        public async Task<IActionResult> OnPostKnittingTensionFilter()
        {
            YarnProducts = await _yarnService.KnittingTensionFilter(KnittingTension);
            return Page();
        }

        public async Task<IActionResult> OnPostYardageFilter()
        {
            YarnProducts = await _yarnService.YardageFilter(Yardage);
            return Page();
        }

        public async Task<IActionResult> OnPostSizeFilter()
        {
            YarnProducts = await _yarnService.SizeFilter(Size);
            return Page();
        }

        public async Task<IActionResult> OnPostAddToCart(int quantity)
        {
            var user = HttpContext.User.FindFirstValue(ClaimTypes.Name);

            if(user is not null)
            {
                var product = await _yarnService.GetYarn(SelectedProductId);
                await _userService.AddToShoppingCart(user, product, quantity);
            }

            return RedirectToPage();
        }

        //public IActionResult OnPostMachinewashFilter()
        //{
        //    YarnProducts = _yarnService.MachinewashFilter(MachineWash).ToList();
        //    return Page();
        //}

    }
}
