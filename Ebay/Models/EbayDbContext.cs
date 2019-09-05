using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ebay.Models
{
    public class EbayDbContext : DbContext
    {
      

        //1- Create Ctor
        public EbayDbContext(DbContextOptions<EbayDbContext> dbContext) :base(dbContext)
        {
            
        }

        //2- OnCreateModel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //3-add your model Dbsets
        public DbSet<Product> products  { get; set; }
        public DbSet<Order> orders      { get; set; }

    }
}
