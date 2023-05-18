using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace WonWorld.Models
{
    public class AppDbContext : DbContext
    {
    
        public DbSet<Users> Users { get; set; }
        public DbSet<InStockMaster> dbInStockMaster { get; set; }
        public DbSet<InStockDetail> dbInStockDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = (localdb)\MSSQLLocalDB;Initial Catalog=M-DB;User ID=sa;Password=dnjs!32433");
        }

   
    }
}

