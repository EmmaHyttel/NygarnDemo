using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;

namespace NygarnDemo.Services.DbServices
{
    public class UserDbService
    {
        public async Task<List<Models.User>> GetUsers()
        {
            using (var context = new UserDbContext())
            {
                return await context.UserTable.ToListAsync();
            }
        }
        public async Task AddUser(Models.User user)
        {
            using (var context = new UserDbContext())
            {
                context.UserTable.Add(user);
                context.SaveChanges();
            }
        }

        public async Task SaveUsers(List<Models.User> users)
        {
            using (var context = new UserDbContext())
            {
                foreach (Models.User user in users)
                {
                    context.UserTable.Add(user);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
