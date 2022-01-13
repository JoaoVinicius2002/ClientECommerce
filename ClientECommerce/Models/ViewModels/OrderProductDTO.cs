using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientECommerce.Models.ViewModels
{
    public class OrderProductDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string OrderAddress { get; set; }
        public DateTime OrderWhenCreated { get; set; }
        public DateTime OrderWhenDelivered { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
