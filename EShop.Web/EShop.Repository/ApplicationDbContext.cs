using EShop.Domain.DomainModels;
using EShop.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EShop.Repository
{
    public class ApplicationDbContext : IdentityDbContext<EShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ProductInShoppingCart> ProductInShoppingCarts { get; set; }
        public virtual DbSet<ProductInOrder> ProductInOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

           // builder.Entity<ProductInShoppingCart>()
              //  .HasKey(z => new { z.ProductId, z.ShoppingCardId });

            builder.Entity<ProductInShoppingCart>()
                .HasOne(z => z.Product)
                .WithMany(t => t.ProductInShoppingCarts)
                .HasForeignKey(z => z.ShoppingCardId);

            builder.Entity<ProductInShoppingCart>()
              .HasOne(z => z.ShoppingCart)
               .WithMany(t => t.ProductInShoppingCarts)
              .HasForeignKey(z => z.ProductId);

            builder.Entity<ShoppingCart>()
                .HasOne<EShopApplicationUser>(z => z.Owner)
                .WithOne(zt => zt.UserCart)
                .HasForeignKey<ShoppingCart>(bc => bc.OwnerId);


           // builder.Entity<ProductInOrder>()
              // .HasKey(z => new { z.ProductId, z.OrderId });

            builder.Entity<ProductInOrder>()
               .HasOne(z => z.OrderedProduct)
               .WithMany(t => t.ProductInOrders)
               .HasForeignKey(z => z.OrderId);

            builder.Entity<ProductInOrder>()
              .HasOne(z => z.UserOrder)
               .WithMany(t => t.Products)
              .HasForeignKey(z => z.ProductId);
        }

    }
}