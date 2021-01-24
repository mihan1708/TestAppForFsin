using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForFSIN.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Technical_inspection> Inspections { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasAlternateKey(c => c.Registration_number);
        }
    }
}
