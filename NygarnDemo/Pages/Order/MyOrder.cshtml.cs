using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Services.User;

namespace NygarnDemo.Pages.Order
{
    public class MyOrderModel : PageModel
    {
        public UserService UserService { get; set; }

        //public IEnumerable<OrderDAO> MyOrders { get; set; }
        public IEnumerable<Models.Order> MyOrders { get; set; }


        public MyOrderModel(UserService userService)
        {
            UserService = userService;
        }
        public IActionResult OnGetAsync()
        {
            Models.User CurrentUser = UserService.GetUserByUserName(HttpContext.User.Identity.Name);
            //MyOrders = UserService.GetUserOrdersAsync(CurrentUser).Result.Orders;

            return Page();
        }

    }
}
