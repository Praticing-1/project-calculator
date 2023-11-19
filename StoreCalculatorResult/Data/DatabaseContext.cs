using Microsoft.EntityFrameworkCore;
using StoreCalculatorResult.Entities;

namespace StoreCalculatorResult.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {
            
        }

        public DbSet<Data>? Data { get; set; }
    }
}