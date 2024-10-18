using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebsiteBanHang_Final.Models;

namespace WebsiteBanHang_Final.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Category - Product relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            // Order - Customer relationship
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);

            // OrderItem - Order relationship
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderID);

            // OrderItem - Product relationship
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductID);

            // ProductReview - Customer relationship
            modelBuilder.Entity<ProductReview>()
                .HasOne(pr => pr.Customer)
                .WithMany()
                .HasForeignKey(pr => pr.CustomerID);

            // ProductReview - Product relationship
            modelBuilder.Entity<ProductReview>()
                .HasOne(pr => pr.Product)
                .WithMany()
                .HasForeignKey(pr => pr.ProductID);

            // Wishlist - Customer relationship
            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Customer)
                .WithMany()
                .HasForeignKey(w => w.CustomerID);

            // Wishlist - Product relationship
            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Product)
                .WithMany()
                .HasForeignKey(w => w.ProductID);
        }

    }
}
