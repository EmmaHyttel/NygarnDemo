using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices
{
    public class CrochetHookDbService
    {
        public async Task<List<CrochetHook>> GetCrochetHooks()
        {
            using (var context = new NygarnDbContext())
            {
                return await context.CrochetHook.ToListAsync();
            }
        }
        public async Task AddCrochetHook(CrochetHook crochetHook)
        {
            using (var context = new NygarnDbContext())
            {
                context.CrochetHook.Add(crochetHook);
                context.SaveChanges();
            }
        }

        public async Task SaveCrochetHooks(List<CrochetHook> crochetHooks)
        {
            using (var context = new NygarnDbContext())
            {
                foreach (CrochetHook hook in crochetHooks)
                {
                    context.CrochetHook.Add(hook);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }

        public async Task DeleteHookAsync(CrochetHook crochetHooks)
        {
            using ( var context = new NygarnDbContext())
            {
                   context.CrochetHook.Remove(crochetHooks);
                   await context.SaveChangesAsync();
                
            }
        }
    }
}
