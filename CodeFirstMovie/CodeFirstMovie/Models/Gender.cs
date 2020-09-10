using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMovie.Models
{
    class Gender
    {
        public Gender()
        {
            Movies = new List<Movie>();
        }
        [Key]
        public int GenderId { get; set; }
        [Column("Gender")]
        public string Gender1 { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
