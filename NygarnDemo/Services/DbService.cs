using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
     
    
        #region User
        public async Task<List<Models.User>> GetUsers()
        {
            using (var context = new UserDbContext())
            {
                return await context.UserTable.ToListAsync();
            }
        }
        public async Task AddUser(Models.User user)
        {
            using (var context = new UserDbContext())
            {
                context.UserTable.Add(user);
                context.SaveChanges();
            }
        }

        public async Task SaveUsers(List<Models.User> users)
        {
            using (var context = new UserDbContext())
            {
                foreach (Models.User user in users)
                {
                    context.UserTable.Add(user);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
		#endregion
		#region KnittingNeedle
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
		#endregion
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
