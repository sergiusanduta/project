using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMovie.Models
{
    class Production
    {
        [Key]
        public int ProductionId { get; set; }
        public string ProductionName { get; set; }
    }
}
