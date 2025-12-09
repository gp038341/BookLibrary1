using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Domain.Entities;

namespace BookLibrary.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(e => e.Author).IsRequired().HasMaxLength(100);
        }
    }
}
