using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Jax.Data
{
    public class JaxDbContext : DbContext
    {
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }

        public JaxDbContext(DbContextOptions<JaxDbContext> options)
            : base(options)
        {
        }
    }
}
