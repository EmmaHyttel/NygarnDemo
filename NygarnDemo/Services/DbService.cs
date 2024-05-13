using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
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

        public async Task UpdateToolAsync(Tool tool)
        {
            using (var context = new ToolDbContext())
            {
                context.ToolProducts.Update(tool);
                await context.SaveChangesAsync();
            }
        }
    }
}
