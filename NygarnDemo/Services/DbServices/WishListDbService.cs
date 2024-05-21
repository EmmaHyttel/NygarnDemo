using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices
{
    public class WishListDbService
    {
        //public async Task<WishList> GetWishList()
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        return await context.WishList.ToListAsync();
        //    }
        //}

        //public async Task AddProduct(Product product)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        await context.WishList.AddAsync(product);
        //        await context.SaveChangesAsync();
        //    }
        //}


        //public async Task SaveProduct(List<Product> products)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        foreach (Product p in products)
        //        {
        //            await context.WishList.AddAsync(p);
        //        }

        //        await context.SaveChangesAsync();
        //    }
        //}


    }
}
