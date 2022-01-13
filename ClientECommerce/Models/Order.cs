using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientECommerce.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int teamId, DateTime whenCreated, DateTime whenDelivered, string address)
        {
            TeamId = teamId;
            WhenCreated = whenCreated;
            WhenDelivered = whenDelivered;
            Address = address;
        }
        public int Id { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public DateTime WhenCreated { get; set; }
        public DateTime WhenDelivered { get; set; }
        public string Address { get; set; }
    }
}
