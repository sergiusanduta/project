using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
