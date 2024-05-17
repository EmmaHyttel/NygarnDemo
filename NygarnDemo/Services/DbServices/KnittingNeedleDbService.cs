using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices
{
    public class KnittingNeedleDbService
    {
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
    }
}
