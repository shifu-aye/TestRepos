using Microsoft.EntityFrameworkCore;
using TestModel.Entities;

namespace TestModel.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=testFirst.db");
        }
    }
}
