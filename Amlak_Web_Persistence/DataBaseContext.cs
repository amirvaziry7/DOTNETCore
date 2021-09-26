using Amlak_Web_Domain.Entity.Ground;
using Amlak_Web_Domain.Entity.Owner;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amlak_Web_Persistence
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {

        }
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Ground> Ground { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasQueryFilter(c => !c.IsRemoved);
            modelBuilder.Entity<Ground>().HasQueryFilter(c => !c.IsRemoved);
            base.OnModelCreating(modelBuilder);

        }
    }
    
}
