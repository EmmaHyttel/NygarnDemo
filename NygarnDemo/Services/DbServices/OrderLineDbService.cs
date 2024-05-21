using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class OrderLineDbService
{
    //public async Task<List<OrderLine>> GetOrderLines()
    //{
    //    using (var context = new NygarnDbContext())
    //    {
    //        return await context.OrderLine.ToListAsync();
    //    }
    //}

    //public async Task AddOrderLine(OrderLine orderLine)
    //{
    //    using (var context = new NygarnDbContext())
    //    {
    //        context.OrderLine.Add(orderLine);
    //        context.SaveChanges();
    //    }
    //}

    //public async Task SaveOrderLines(List<OrderLine> orderLines)
    //{
    //    using (var context = new NygarnDbContext())
    //    {
    //        foreach (OrderLine orderLine in orderLines)
    //        {
    //            context.OrderLine.Add(orderLine);
    //            context.SaveChanges();
    //        }

    //        context.SaveChanges();
    //    }
    //}
}
