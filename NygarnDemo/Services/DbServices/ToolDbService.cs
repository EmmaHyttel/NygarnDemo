using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class ToolDbService
{
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
            await context.ToolProducts.AddAsync(tool);
            await context.SaveChangesAsync();
        }
    }


    public async Task SaveTools(List<Tool> tools)
    {
        using (var context = new ToolDbContext())
        {
            foreach (Tool tool in tools)
            {
                await context.ToolProducts.AddAsync(tool);
            }

            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteToolAsync(Tool tool)
    {
        using (var context = new ToolDbContext())
        {
            context.ToolProducts.Remove(tool);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateTool(Tool tool)
    {
        using (var context = new ToolDbContext())
        {
            context.ToolProducts.Update(tool);
            await context.SaveChangesAsync();
        }
    }
}
