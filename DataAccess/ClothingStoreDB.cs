using Microsoft.EntityFrameworkCore;
using Model;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DataAccssesLayer
{
    public class ClothingStoreDB : DbContext
    {
        
        //public ClothingStoreDB()
        //{

        //}
        

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }



        // Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ClothingStoreDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderID, op.ProductID });

           

            modelBuilder.Entity<Order>().Property(e => e.ProductsQuantity).HasConversion(
                  v => JsonConvert.SerializeObject(v, new JsonSerializerSettings
                  { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<Dictionary<int,int>>(v, new JsonSerializerSettings
                { NullValueHandling = NullValueHandling.Ignore }));

        }

    }

   
}
