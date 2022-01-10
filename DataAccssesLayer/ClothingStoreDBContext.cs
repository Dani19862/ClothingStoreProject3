using Microsoft.EntityFrameworkCore;
using Models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccssesLayer
{
    public class ClothingStoreDBContext : DbContext
    {
        //public OnlineShopDBContext() :base()
        //{
            
        //}
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<OrdersDetails> OrdersDetails { get; set; }

        //public ICollection<Orders> OrdersCollection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ClothingStoreDB;Trusted_Connection=True;MultipleActiveResultSets=true;");

                //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BlogDB;Trusted_Connection=True;MultipleActiveResultSets=true;")
                //    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            }
        }
    }
}
