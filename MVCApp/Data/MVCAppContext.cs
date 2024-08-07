using Microsoft.EntityFrameworkCore;
using MVCApp.Models;
using System.Configuration;

namespace MVCApp.Data
{
    public class MVCAppContext : DbContext
    {
        public MVCAppContext(DbContextOptions<MVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Contact>().ToTable("Contact");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MVCApp;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }   
}
