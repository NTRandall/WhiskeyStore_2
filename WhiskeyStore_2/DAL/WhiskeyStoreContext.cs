using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhiskeyStore_2.Models;

namespace WhiskeyStore_2.DAL
{
    public class WhiskeyStoreContext:DbContext
    {
        public WhiskeyStoreContext() : base("WhiskeyStore")
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<WhiskeyStore_2.Models.ShoppingCart> ShoppingCarts { get; set; }
    }
}