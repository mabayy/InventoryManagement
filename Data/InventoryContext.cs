using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
    }
}
