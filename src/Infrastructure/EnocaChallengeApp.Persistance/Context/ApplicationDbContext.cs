using EnocaChallengeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Persistance.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=AppDb; uid=sa; pwd=123; TrustServerCertificate=True");
        }
    }
}
