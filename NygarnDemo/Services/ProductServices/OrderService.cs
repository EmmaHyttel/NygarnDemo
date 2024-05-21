using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;

namespace NygarnDemo.Services.ProductServices
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; }

        public OrderDbService<Order> _dbService { get; set; }

        public OrderService(OrderDbService<Order> dbService)
        {
            _dbService = dbService;
            OrderList = _dbService.GetObjectsAsync().Result.ToList();
        }

        public async Task AddOrderAsync(Order order)
        {
            OrderList.Add(order);
            await _dbService.AddObjectAsync(order);
        }
    }
}
