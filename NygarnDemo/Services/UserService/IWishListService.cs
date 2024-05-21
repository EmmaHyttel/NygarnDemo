using NygarnDemo.Models;

namespace NygarnDemo.Services.UserService
{
    public interface IWishListService
    {
        List<Product> GetWishList();

        Task AddProductAsync(Product product);

        WishList GetUserByUserName(string str);
    }
}
