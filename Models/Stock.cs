using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BikeShopPartsMVC.Models
{
public class Stock
{
        public Guid StockId { get; set; }
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }
        [Display(Name = "Product Description")]
        public string? ProductDescription { get; set; }
        [Display(Name = "Product Type")]
        public string? ProductType { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
