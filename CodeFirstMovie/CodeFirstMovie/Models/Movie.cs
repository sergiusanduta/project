using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMovie.Models
{
    class Movie
    {

        public Movie()
        {
            Genders = new List<Gender>();
        }
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateReleased { get; set; }
        public int RatingId { get; set; }
        public int ProductionId { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual Production Production { get; set; }
        public virtual List<Gender> Genders { get; set; }
    }
}
