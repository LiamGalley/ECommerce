﻿using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Orders.Db
{
    public class OrdersDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }

        public OrdersDbContext(DbContextOptions options) : 
            base(options)
        {
            
        }
    }
}
