using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.ExternalSupplier.Common.Models;

namespace OpenQbit.ExternalSupplier.Dal.DataAccess
{
    public class DbContextSupplier: DbContext
    {
        public DbContextSupplier() : base("DbContextSupplier")
        {
           
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items {get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemPrice> itemprices{ get; set; }
        public DbSet<ItemStock> itemStocks { get; set; }
        public DbSet<OrderDetails> orderDetail{ get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
