using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    class OnlineStoreContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
            : base(options)
        {

        }
        DbSet<Store> Stores { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
