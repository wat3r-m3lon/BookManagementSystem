using BookManagementDomain.Models.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Data.Data
{
    public class BookManagementDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}