﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jax.Models;
using Microsoft.EntityFrameworkCore;

namespace Jax
{
    public class JaxContext : DbContext
    {
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }

        public JaxContext()
        {
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                @"Data Source=localhost;port=3306;Initial Catalog=Jax;user id=root;password=shinff820;CharSet=utf8;", b => b.MigrationsAssembly("Jax"));
        }
    }
}
