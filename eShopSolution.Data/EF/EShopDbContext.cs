using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //using fluent API
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleCofiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x=>new {x.UserId,x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId); 
            //data seeding : dữ liệu chim muồi
            /*modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" }
                new AppConfig() { Key = "HomeKeywoed", Value = "This is Key word of eShopSolution" }
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
            );*/
            modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<AppConfig> AppConfigs { set; get; }
        public DbSet<Cart> Carts { set; get; }
        public DbSet<CategoryTranslation> CategoryTranslations { set; get; }
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<Language> Languages { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDatails { set; get; }
        public DbSet<ProductInCategory> ProductInCategories { set; get; }
        public DbSet<ProductTranslation> ProductTranslations { set; get; }
        public DbSet<Promotion> Promotions { set; get; }
        public DbSet<Transaction> Transactions { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
    }
}
