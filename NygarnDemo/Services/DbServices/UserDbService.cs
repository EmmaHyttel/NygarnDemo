using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;

namespace NygarnDemo.Services.DbServices
{
    public class UserDbService
    {
        
        public async Task<List<Models.User>> GetUsers()
        {
            using (var context = new NygarnDbContext())
            {
                return await context.User.ToListAsync();
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
}
