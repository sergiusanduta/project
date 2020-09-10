using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMovie.Models
{
    class Rating
    {
        [Key]
        public int RatingId { get; set; }
        [Column("Rating")]
        public int Rating1 { get; set; }
    }
}
