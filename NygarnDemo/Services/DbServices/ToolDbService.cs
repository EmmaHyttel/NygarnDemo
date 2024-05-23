using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class ToolDbService
{
    public async Task<List<Tool>> GetTools()
    {
        using (var context = new NygarnDbContext())
        {
            return await context.Tool.ToListAsync();
        }
    }

    public async Task AddTool(Tool tool)
    {
        using (var context = new NygarnDbContext())
        {
            await context.Tool.AddAsync(tool);
            await context.SaveChangesAsync();
        }
    }


    public async Task SaveTools(List<Tool> tools)
    {
        using (var context = new NygarnDbContext())
        {
            foreach (Tool tool in tools)
            {
                await context.Tool.AddAsync(tool);
            }

            await context.SaveChangesAsync();
        }
    }

    public async Task DeleteToolAsync(Tool tool)
    {
        using (var context = new NygarnDbContext())
        {
            context.Tool.Remove(tool);
            await context.SaveChangesAsync();
        }
    }

    public async Task UpdateTool(Tool tool)
    {
        using (var context = new NygarnDbContext())
        {
            context.Tool.Update(tool);
            await context.SaveChangesAsync();
        }
    }
}
