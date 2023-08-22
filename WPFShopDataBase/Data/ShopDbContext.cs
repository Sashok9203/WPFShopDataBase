﻿using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WPFShopDataBase.Entities;

namespace WPFShopDataBase.Data
{
    public class ShopDbContext:DbContext
    {
        public ShopDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connect = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
            optionsBuilder.UseSqlServer(connect);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(Data.Cities);
            modelBuilder.Entity<Country>().HasData(Data.Countries);
            modelBuilder.Entity<Shop>().HasData(Data.Shops);
            modelBuilder.Entity<Category>().HasData(Data.Categories);
            modelBuilder.Entity<Position>().HasData(Data.Positions);
            modelBuilder.Entity<Product>().HasData(Data.Products);
            modelBuilder.Entity<Worker>().HasData(Data.Workers);
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
