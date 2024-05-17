using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices
{
    public class CrochetHookDbService
    {
        public async Task<List<CrochetHook>> GetCrochetHooks()
        {
            using (var context = new HookDbContext())
            {
                return await context.CrochetHook.ToListAsync();
            }
        }
        public async Task AddCrochetHook(CrochetHook crochetHook)
        {
            using (var context = new HookDbContext())
            {
                context.CrochetHook.Add(crochetHook);
                context.SaveChanges();
            }
        }

        public async Task SaveCrochetHooks(List<CrochetHook> crochetHooks)
        {
            using (var context = new HookDbContext())
            {
                foreach (CrochetHook hook in crochetHooks)
                {
                    context.CrochetHook.Add(hook);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
