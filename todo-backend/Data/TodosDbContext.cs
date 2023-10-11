using Microsoft.EntityFrameworkCore;
using todo_backend.Configuration;
using todo_backend.Seeders;

namespace todo_backend.Data
{
    public class TodosDbContext : DbContext
    {
        public TodosDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            modelBuilder.Seed();
        }
    }
}
