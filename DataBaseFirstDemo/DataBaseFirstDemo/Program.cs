using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataBaseFirstDemoEntities();
            var post = new Post()
            {
                Body = " Body",
                DatePublished = DateTime.Now,
                Title = "Title",
                PostID = 1
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
