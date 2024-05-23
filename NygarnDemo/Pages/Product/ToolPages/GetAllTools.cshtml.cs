using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
using System.Security.Claims;

namespace NygarnDemo.Pages.Product.ToolPages
{
    public class GetAllToolsModel : PageModel
    {
        private readonly NygarnDbContext _dbContext;
        private IToolService _toolService;
        public bool IsAdmin { get; private set; }

        public GetAllToolsModel(IToolService toolService, NygarnDbContext toolContext)
        {
            _toolService = toolService;
            _dbContext = toolContext;
        }

        public IList<Tool>? Tools { get; private set; }

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
        [BindProperty]
        public int DeletedToolId { get; set; }

        public async Task OnGetAsync()
        {
            //Tools = _toolService.GetToolsProducts();
            Tools = await _dbContext.Tool.ToListAsync();
            IsAdmin = HttpContext.User.HasClaim(c => c.Type == ClaimTypes.Role && c.Value == "admin");
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

        //public async Task<IActionResult> OnPostDeleteTool()
        //{
        //    // Check if DeletedToolId is valid
        //    //if (DeletedToolId == 0)
        //    //{
        //    //    return RedirectToPage("/Index");
        //    //}

        //    // Fetch the tool to be deleted
        //    var tool = await _toolService.GetTool(DeletedToolId);
        //    if (tool == null)
        //    {
        //        return RedirectToPage("/Index");
        //    }

        //    // Delete the tool
        //    await _toolService.DeleteTool(tool);

        //    // Redirect to GetAllTools page
        //    return RedirectToPage("GetAllTools");
        //}
    }
}
