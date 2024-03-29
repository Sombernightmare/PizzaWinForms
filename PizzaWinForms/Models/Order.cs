﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Models
{
    public enum OrderType
    {
        CarryOut, 
        Delivery
    }
    public class Order
    {

        public int ID { get; set; }

        [Required]
        public OrderType OrderType { get; set; }
        public Employee Driver { get; set; }
        public DateTime? DriverOut { get; set; }
        public DateTime? DriverIn { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
