using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEntityFramework2.Models
{
    class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
