using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMovie.Models
{
    class MovieContext : DbContext
    {
        public MovieContext() : base("DefaultConnection")
        {

        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Rating> Ratings { get; set; }

    }
}
