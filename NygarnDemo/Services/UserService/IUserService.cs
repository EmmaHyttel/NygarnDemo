using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public interface IUserService
    {
        List<Models.User> GetUsers();

        Task AddUserAsync(Models.User user);

        Models.User GetUserByUserName(string str);

        Task AddToShoppingCart(string userName, Product product, int count);
        Task<List<ShoppingCartLine>> GetShoppingCartByUserName(string username);

    }
}