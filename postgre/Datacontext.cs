using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace postgre
{
    public class Datacontext : DbContext
    {
        public DbSet<Student> Users { get; set; }
        public Datacontext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Students;Username=postgres;Password=Pro100sme9!");
        }
    }
}
