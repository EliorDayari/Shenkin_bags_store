using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinBagsStore.Models
{
 
        public class MVCShenkinBagsStoreContext : DbContext
        {
        public MVCShenkinBagsStoreContext()
        {
        }

        public MVCShenkinBagsStoreContext(DbContextOptions<MVCShenkinBagsStoreContext> options) : base(options)
            {
            }


        public DbSet<Product> Products { get; set; }


            public DbSet<User> Users { get; set; }


            public DbSet<Transaction> Transactions { get; set; }

        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
    
}
