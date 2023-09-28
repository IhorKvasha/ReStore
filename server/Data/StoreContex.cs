using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContex : DbContext
    {
        public StoreContex(DbContextOptions options) : base(options)
        { 
            
        }

        public DbSet<Product> Products { get; set; }
    }
} 