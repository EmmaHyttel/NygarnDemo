using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
	
        #region OrderLine
        public async Task<List<OrderLine>> GetOrderLines()
        {
            using (var context = new OrderLineDbContext())
            {
                return await context.OrderLines.ToListAsync();
            }
        }

        public async Task AddOrderLine(OrderLine orderLine)
        {
            using (var context = new OrderLineDbContext())
            {
                context.OrderLines.Add(orderLine);
                context.SaveChanges();
            }
        }

        public async Task SaveOrderLines(List<OrderLine> orderLines)
        {
            using (var context = new OrderLineDbContext())
            {
                foreach (OrderLine orderLine in orderLines)
                {
                    context.OrderLines.Add(orderLine);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
        #endregion
    }
}
