﻿using NygarnDemo.Models;

namespace NygarnDemo.Services.User
{
    public interface IUserService
    {
        List<Models.User> GetUsers();

        Task AddUserAsync(Models.User user);

        Models.User GetUserByUserName(string str);

        Task AddToShoppingCart(string userName, Product product, int quantity);
        Task<List<ShoppingCartLine>> GetShoppingCartByUserName(string username);

        Task UpdateShoppingCart(string userName, int productId, int quantity);
        Task AddToWishList(string userName, Product product);
        Task<List<WishListLine>> GetWishListByUserName(string userName);
    }
}