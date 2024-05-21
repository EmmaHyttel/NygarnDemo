using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.DbServices
{
    public class GenericDbService<T> : IService<T> where T : class
    {
        //public async Task AddObjectAsync(T obj)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        context.Set<T>().Add(obj);
        //        await context.SaveChangesAsync();
        //    }
        //}

        //public async Task DeleteObjectAsync(T obj)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        context.Set<T>().Remove(obj);
        //        await context.SaveChangesAsync();
        //    }
        //}

        //public async Task<T> GetObjectByIdAsync(int id)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        return await context.Set<T>().FindAsync(id);
        //    }
        //}

        //public async Task<IEnumerable<T>> GetObjectsAsync()
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        return await context.Set<T>().AsNoTracking().ToListAsync();
        //    }
        //}

        //public async Task UpdateObjectAsync(T obj)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        context.Set<T>().Update(obj);
        //        await context.SaveChangesAsync();
        //    }
        //}

        //public async Task SaveObjects(List<T> objs)
        //{
        //    using (var context = new NygarnDbContext())
        //    {
        //        foreach (T obj in objs)
        //        {
        //            context.Set<T>().Add(obj);
        //            context.SaveChanges();
        //        }

        //        context.SaveChanges();
        //    }
        //}
    }
}
