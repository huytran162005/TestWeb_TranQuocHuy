using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_TranQuocHuy.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        { }
        public DbSet<Book> books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //them du lieu Product
            modelBuilder.Entity<Book>().HasData(
            new Book { Id = 00001, Title = "Lập trình web", Price = 32300, Author = "Huy", Quantilty = 9 },
            new Book { Id = 00002, Title = "Cấu trúc dữ liệu và giải thuật", Price = 2300, Author = "Phu", Quantilty = 12 },
            new Book { Id = 00003, Title = "Kỹ thuật lập trình", Price = 5300, Author = "Huy", Quantilty = 5 },
            new Book { Id = 00004, Title = "Lập trình Java coer", Price = 3300, Author = "Phu", Quantilty = 2 },
            new Book { Id = 00005, Title = "Cơ sở dữ liệu", Price = 1300, Author = "Huy", Quantilty = 9 }
            
            );
          }
    }
}
