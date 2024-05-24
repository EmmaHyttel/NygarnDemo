using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;

namespace NygarnDemo.Services.User;

public class UserService : IUserService
{
    private UserDbService _userDbService;
    public List<Models.User> Users { get; set; }

    public UserService(UserDbService dbService)
    {
        //Users = MockUser.GetAllUsers();
        _userDbService = dbService;
        Users = _userDbService.GetUsers().Result.ToList();
        _userDbService.SaveUsers(Users);
    }
    public List<Models.User> GetUsers()
    {
        return Users;
    }

    public Models.User GetUserByUserName(string username)
    {
        //return DbService.GetObjectByIdAsync(username).Result;
        return Users.Find(user => user.UserName == username);
    }

    public List<Models.User> GetAllUsers()
    {
        return Users;
    }

    public async Task AddUserAsync(Models.User user)
    {
        if (await _userDbService.GetUserByUsername(user.UserName) != null)
        {
            throw new Exception("Brugernavnet er allerede taget, prøv en anden ;)");
        }

        await _userDbService.AddUser(user);
        Users.Add(user);
    }

    public async Task AddToShoppingCart(string username, Product product, int quantity)
    {
        var user = await _userDbService.GetUserByUsername(username);

        if (user is not null)
        {
            await _userDbService.AddToShoppingCart(user.Id, product, quantity);
        }
    }

    public async Task<List<ShoppingCartLine>> GetShoppingCartByUserName(string username)
    {
        var user = await _userDbService.GetUserByUsername(username);

        if (user is not null)
        {
            return await _userDbService.GetShoppingCart(user.Id);
        }

        return new List<ShoppingCartLine>();
    }


        //public async Task<Models.User> GetUserOrdersAsync(Models.User user)
        //{
        //    return await _userDbService.GetOrdersByUserIdAsync(user.Id);
        //}
    
}
