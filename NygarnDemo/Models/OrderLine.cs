using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    public class OrderLine
    {
        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public int ProductId { get; set; }

        public List<Product> Products { get; set; }

        public OrderLine()
        {
        }

        public OrderLine(int orderId, Order order, int productId, Product product)
        {
            OrderId = orderId;
            Order = order;
            ProductId = productId;
            Product = product;
        }
    }
}
