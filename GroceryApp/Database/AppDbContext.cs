using Microsoft.EntityFrameworkCore;
using GroceryApp.Models;

namespace GroceryApp.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Subcategories> Subcategories { get; set; }
        public DbSet<Products> Products { get; set; }
        
    }
}
