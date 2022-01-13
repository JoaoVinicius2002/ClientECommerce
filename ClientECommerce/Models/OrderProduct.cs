using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientECommerce.Models
{
    public class OrderProduct
    {
        public OrderProduct(int orderId, int productId)
        {
            OrderId = orderId;
            ProductId = productId;
        }
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
