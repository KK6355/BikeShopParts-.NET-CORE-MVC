using System.ComponentModel.DataAnnotations;
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

        public Customer? Customer { get; set; }
        public Staff? Staff { get; set; }
        public Stock? Stock { get; set; }
    }
}
