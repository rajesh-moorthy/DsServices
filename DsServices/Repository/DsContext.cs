using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DsServices.Models;

namespace DsServices.Repository
{
    public class DsContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Preference> Preferences { get; set; }

        public DbSet<Cities> city { get; set; }

        public DbSet<AdImage> AdImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;Port=3306;database=dealsqare;user=Rajesh;password=Rajesh@1234!");
        }
    }
}
