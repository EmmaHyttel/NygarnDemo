﻿using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class UserDbService
{
    public async Task<List<Models.User>> GetUsers()
    {
        using (var context = new NygarnDbContext())
        {
            return await context.User.ToListAsync();
        }
    }

    public async Task<Models.User?> GetUserByUsername(string username)
    {
        using (var context = new NygarnDbContext())
        {
            return await context.User.FirstOrDefaultAsync(x => x.UserName == username);
        }
    }

    public async Task AddUser(Models.User user)
    {
        using (var context = new NygarnDbContext())
        {
            context.User.Add(user);
            context.SaveChanges();
        }
    }

    public async Task SaveUsers(List<Models.User> users)
    {
        using (var context = new NygarnDbContext())
        {
            foreach (Models.User user in users)
            {
                context.User.Add(user);
                context.SaveChanges();
            }

            context.SaveChanges();
        }
    }

    public async Task AddToShoppingCart(int userId, Product product, int quantity)
    {
        using (var context = new NygarnDbContext())
        {
            var user = await context.User.FirstOrDefaultAsync(x => x.Id == userId);

            if(user is not null)
            {
                user.ShoppingCartLines.Add(new ShoppingCartLine(product, quantity));
                context.SaveChanges();
            }

        }            
    }

    public async Task<List<ShoppingCartLine>> GetShoppingCart(int userId)
    {
        using (var context = new NygarnDbContext())
        {
            var user = await context.User
                       .Include(u => u.ShoppingCartLines)
                       .ThenInclude(scl => scl.Product)
                       .FirstOrDefaultAsync(u => u.Id == userId);

            if (user is not null)
            {
                return user.ShoppingCartLines;
            }

            return new List<ShoppingCartLine>();
        }
    }

    public async Task UpdateShoppingCartAsync(int userId, List<ShoppingCartLine> shoppingCartLines)
    {
        using (var context = new NygarnDbContext())
        {
            var user = await context.User
                .Include(u => u.ShoppingCartLines)
                .FirstOrDefaultAsync(x => x.Id == userId);

            if (user != null)
            {
                foreach (var line in shoppingCartLines)
                {
                    var existingLine = user.ShoppingCartLines.FirstOrDefault(l => l.Id == line.Id);

                    if (existingLine != null)
                    {
                        existingLine.Quantity = line.Quantity;
                    }
                }
            }
        }
    }
    //public async Task<Models.User> GetOrdersByUserIdAsync(int id)
    //{
    //    Models.User user;

    //    using (var context = new NygarnDbContext())
    //    {
    //        user = context.Users
    //        .Include(u => u.Order)
    //        .ThenInclude(i => i.Product)
    //        .AsNoTracking()
    //        .FirstOrDefault(u => u.Id == id);
    //    }

    //    return user;
    //}
}
