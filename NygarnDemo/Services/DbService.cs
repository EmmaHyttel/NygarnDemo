using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
        #region Yarn
        public async Task<List<Yarn>> GetYarnProducts()
        {
            using (var context = new YarnDbContext())
            {
                return await context.YarnProducts.ToListAsync();
            }
        }

        public async Task AddYarn(Yarn yarn)
        {
            using (var context = new YarnDbContext())
            {
                context.YarnProducts.Add(yarn);
                context.SaveChanges();
            }
        }

        public async Task SaveYarnProducts(List<Yarn> yarnProducts)
        {
            using (var context = new YarnDbContext())
            {
                foreach (Yarn yarn in yarnProducts)
                {
                    context.YarnProducts.Add(yarn);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
        #endregion
        public async Task<List<Tool>> GetTools()
        {
            using (var context = new ToolDbContext())
            {
                return await context.ToolProducts.ToListAsync();
            }
        }

        public async Task AddTools(Tool tool)
        {
            using (var context = new ToolDbContext())
            {
                context.ToolProducts.Add(tool);
                context.SaveChanges();
            }
        }


        public async Task SaveTools(List<Tool> tools)
        {
            using (var context = new ToolDbContext())
            {
                foreach (Tool tool in tools)
                {
                    context.ToolProducts.Add(tool);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }

        public async Task DeleteToolsAsync(Tool tool)
        {
            using (var context = new ToolDbContext())
            {
                context.ToolProducts.Remove(tool);
                await context.SaveChangesAsync();
            }
        }
        #region User
        public async Task<List<Models.User>> GetUsers()
        {
            using (var context = new UserDbContext())
            {
                return await context.Users.ToListAsync();
            }
        }
        public async Task AddUser(Models.User user)
        {
            using (var context = new UserDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public async Task SaveUsers(List<Models.User> users)
        {
            using (var context = new UserDbContext())
            {
                foreach (Models.User user in users)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }

        public async Task<List<KnittingNeedle>> GetKnittingNeedles()
        {
            using (var context = new NeedleDbContext())
            {
                return await context.KnittingNeedles.ToListAsync();
            }
        }
        public async Task AddKnittingNeedle(KnittingNeedle knittingNeedle)
        {
            using (var context = new NeedleDbContext())
            {
                context.KnittingNeedles.Add(knittingNeedle);
                context.SaveChanges();
            }
        }
        
        public async Task SaveKnittingNeedles(List<KnittingNeedle> knittingNeedles)
        {
            using (var context = new NeedleDbContext())
            {
                foreach (KnittingNeedle knitting in knittingNeedles)
                {
                    context.KnittingNeedles.Add(knitting);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
        #endregion
    }
}
