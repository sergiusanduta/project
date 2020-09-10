using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Entity_Framework
{
    public class Product
    {
        public Product()
        {
            Orders = new List<Order>();
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Order> Orders { get; set; }
    }
}
