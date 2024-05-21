using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices
{
    public class KnittingNeedleDbService
    {
        public async Task<List<KnittingNeedle>> GetKnittingNeedles()
        {
            using (var context = new NygarnDbContext())
            {
                return await context.KnittingNeedle.ToListAsync();
            }
        }
        public async Task AddKnittingNeedle(KnittingNeedle knittingNeedle)
        {
            using (var context = new NygarnDbContext())
            {
                context.KnittingNeedle.Add(knittingNeedle);
                context.SaveChanges();
            }
        }

        public async Task SaveKnittingNeedles(List<KnittingNeedle> knittingNeedles)
        {
            using (var context = new NygarnDbContext())
            {
                foreach (KnittingNeedle knitting in knittingNeedles)
                {
                    context.KnittingNeedle.Add(knitting);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
