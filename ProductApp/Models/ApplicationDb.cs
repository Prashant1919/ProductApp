using Microsoft.EntityFrameworkCore;

namespace ProductApp.Models
{
    public class ApplicationDb :DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }
    
}
