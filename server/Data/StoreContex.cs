using API.Entities;
using Microsoft.EntityFrameworkCore;
using server.Entities;

namespace API.Data
{
    public class StoreContex : DbContext
    {
        public StoreContex(DbContextOptions options) : base(options)
        { 
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
} 