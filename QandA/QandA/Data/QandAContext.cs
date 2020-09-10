using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QandA.Data
{
    public class QandAContext: DbContext
    {
        public QandAContext(DbContextOptions<QandAContext>options):base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
