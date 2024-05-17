using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Services.User;

namespace NygarnDemo.Pages.Order
{
    public class MyOrderModel : PageModel
    {
        //private readonly OrderLineDbContext _context;

        //public MyOrderModel(OrderLineDbContext context)
        //{
        //    _context = context;
        //}

        //[BindProperty]
        //public Models.Order Order { get; set; }

        //public void OnGet()
        //{
        //    //Order = new Order();
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Orders.Add(Order);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}

    }
}
