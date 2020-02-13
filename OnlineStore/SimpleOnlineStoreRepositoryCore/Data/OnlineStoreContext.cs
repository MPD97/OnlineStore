using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class OnlineStoreContext : IdentityDbContext<AppUser, AppRole, int>
    {
        private readonly IConfiguration _configuration;

        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        DbSet<Cart> Carts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductMain> ProductsMain { get; set; }
        DbSet<ProductVariant> ProductsVariant { get; set; }
        DbSet<Purchased> Purchases { get; set; }
        DbSet<Store> Stores { get; set; }
        DbSet<Transaction> Transactions { get; set; }
    }
}
