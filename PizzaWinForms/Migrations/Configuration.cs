namespace PizzaWinForms.Migrations
{
    using PizzaStore.Data;
    using PizzaStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaStore.Data.PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaContext context)
        {
            SeedEmployees(context);
            SeedCustomers(context);
            SeedInventoryItems(context);
        }

        private void SeedInventoryItems(PizzaContext context)
        {
            if (context.InventoryItems.Any())
            {
                return;
            }

            InventoryItem[] inventoryItems = new InventoryItem[]
            {
                new InventoryItem{Name="Pepperoni", Type=InventoryItemType.Topping, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Sausage", Type=InventoryItemType.Topping, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Mozerella", Type=InventoryItemType.Cheese, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Coke", Type=InventoryItemType.Flavor, QuantityRemaining=50, PricePerUnit=.50M},
            };

            context.InventoryItems.AddRange(inventoryItems);
            context.SaveChanges();
        }

        private void SeedCustomers(PizzaContext context)
        {
            if (context.Customers.Any())
            {
                return;
            }

            Customer[] customers = new Customer[]
            {
                new Customer{FirstName = "John", LastName = "Fleet", PhoneNumber = "215-555-5527",StreetAddress = "9570 Broken Dawn Dr", City = "Huntsville", State = "Va", Zip = 35809 },
                new Customer{FirstName = "Jamie", LastName = "Beggar", PhoneNumber = "123-555-7349", StreetAddress = "9890 Half Circle Av", City = "Chicago", State = "Il", Zip = 46809},
                new Customer{FirstName = "Karen", LastName = "Bassk", PhoneNumber = "846-555-9465", StreetAddress = "6470 Twisted Square Rd", City = "New York City", State = "NY", Zip = 65879},
                new Customer{FirstName = "Dave", LastName = "Gnome", PhoneNumber = "352-555-5453", StreetAddress = "9552 Upside Monkey Av", City = "St. Louis", State = "Mo", Zip = 89189},
                new Customer{FirstName = "Sammy", LastName = "Aboleth", PhoneNumber = "896-555-7694", StreetAddress = "1594 Delta Prime Cr", City = "San Diego", State = "Ca", Zip = 70026}
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private void SeedEmployees(PizzaContext context)
        {
            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "Donell", LastName = "Banks", PhoneNumber = "205-555-5557", Role = Roles.Manager, Salary = 97000m},
                new Employee{FirstName = "Jax", LastName = "Cassidy", PhoneNumber = "124-555-7849", Role = Roles.AssistantManager, Salary = 60000m},
                new Employee{FirstName = "Dilara", LastName = "Gardiner", PhoneNumber = "896-555-9565", Role = Roles.Driver, Salary = 30000m},
                new Employee{FirstName = "Hammad", LastName = "Goff", PhoneNumber = "322-555-5463", Role = Roles.Insider, Salary = 26000m},
                new Employee{FirstName = "Ayah", LastName = "Hodges", PhoneNumber = "895-555-7894", Role = Roles.Cashier, Salary = 24000m}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
