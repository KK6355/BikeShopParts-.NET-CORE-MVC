﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BikeShopPartsMVC.Models
{
public class Order
{
        public Guid OrderId { get; set; }
        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }
        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }
        public Guid CustomerId { get; set; }
        public Guid StockId { get; set; }
        public Guid StaffId { get; set; }

        Customer? Customer { get; set; }
        Staff? Staff { get; set; }
        Stock? Stock { get; set; }
    }
}