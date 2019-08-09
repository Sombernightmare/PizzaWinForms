using PizzaStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class Customer
    {
        private static PizzaContext _context = new PizzaContext();
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }

        public static List<Customer> FindCustomers(string name, string address, string phone)
        {
            if (string.IsNullOrWhiteSpace(address) && string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(phone))
            {                
                return null;
            }

            return _context.Customers.Where(c => name == "" || c.FirstName.Contains(name) || c.LastName.Contains(name))
                                     .Where(c => address == "" || c.StreetAddress.Contains(address))
                                     .Where(c => phone == "" || c.PhoneNumber.Contains(phone))
                                     .ToList();
        }

    }
}
