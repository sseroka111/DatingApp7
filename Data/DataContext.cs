using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext  // DataContext class is instantiated by the framework
    {
        public DataContext(DbContextOptions options) : base(options) // configure a class and make connection to the database
        {

        }

        public DbSet<AppUser> Users {get ; set; } // DbSet Represent tables inside database //changed MyProperty to Users
        
    }
}