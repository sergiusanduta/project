using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEntityFramework2.Models
{
    class CustomersContext : DbContext
    {
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<CustomersAddress> CustomersAddresses { get; set; }
    }
}
