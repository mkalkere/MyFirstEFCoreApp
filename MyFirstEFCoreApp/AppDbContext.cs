using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstEFCoreApp
{
    public class AppDbContext : DbContext
    {


        private const string connectionString = @"Server=(localdb)\mssqllocaldb;Database=MyFirstEfCoreDb;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}
