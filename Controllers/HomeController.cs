using System.Diagnostics;

using BikeShopPartsMVC.Data;
using BikeShopPartsMVC.Models;

using Microsoft.AspNetCore.Mvc;

namespace BikeShopPartsMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var totalCustomers = _context.Customer.Count();
            ViewData["CustomerCount"] = totalCustomers;
            var totalStock = _context.Stock.Count();
            ViewData["StockCount"] = totalStock;
            var totalOrders = _context.Order.Count();
            ViewData["OrderCount"] = totalOrders;
            var totalStaff = _context.Staff.Count();
            ViewData["StaffCount"] = totalStaff;
            var customersMadeOrder = _context.Order.GroupBy(o=>o.CustomerId).Count();
            ViewData["customersMadeOrder"] = customersMadeOrder;
            var productTypes = _context.Stock.GroupBy(s => s.ProductType).Count();
            ViewData["productTypes"] = productTypes;

            var thisYearOrder = _context.Order.Where(o => o.OrderDate.Value.Year == DateTime.Now.Year).Count();
            ViewData["thisYearOrder"] = thisYearOrder;
            //var topSales = _context.Order.GroupBy(o => o.Staff.Name).Take(1).ToString();
            //ViewData["topSales"] = topSales;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}