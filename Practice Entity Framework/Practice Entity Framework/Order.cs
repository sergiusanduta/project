using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Entity_Framework
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Product> Products{ get; set; }
    }
}
