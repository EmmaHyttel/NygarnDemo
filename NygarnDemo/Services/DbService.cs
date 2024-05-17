﻿using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
		#region CrochetHook
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
        #endregion
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
