using NygarnDemo.Models;

namespace NygarnDemo.Services.UserService
{
    public interface IWishListService
    {
        List<Product> GetWishList();

        Task AddProductAsync(WishList wishList);

        WishList GetUserByUserName(string str);
    }
}
