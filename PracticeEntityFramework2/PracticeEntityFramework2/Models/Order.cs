using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEntityFramework2.Models
{
    class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
