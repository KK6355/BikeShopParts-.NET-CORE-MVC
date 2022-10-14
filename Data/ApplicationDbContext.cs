using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BikeShopPartsMVC.Models;

namespace BikeShopPartsMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BikeShopPartsMVC.Models.Customer> Customer { get; set; }
        public DbSet<BikeShopPartsMVC.Models.Order> Order { get; set; }
        public DbSet<BikeShopPartsMVC.Models.Staff> Staff { get; set; }
        public DbSet<BikeShopPartsMVC.Models.Stock> Stock { get; set; }
    }
}