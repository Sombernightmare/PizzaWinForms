using PizzaStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Data
{
    public class PizzaContext: DbContext
    {
        public PizzaContext(): base("name=DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<InventoryItem> InventoryItems { get; set; }

    }

}
