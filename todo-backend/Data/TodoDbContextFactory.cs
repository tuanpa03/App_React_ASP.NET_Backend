using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace todo_backend.Data
{
    public class TodoDbContextFactory : IDesignTimeDbContextFactory<TodosDbContext>
    {
        public TodosDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configurationRoot.GetConnectionString("TodoDatabase");
            var optionBuilder = new DbContextOptionsBuilder<TodosDbContext>();

            optionBuilder.UseSqlServer(connectionString);

            return new TodosDbContext(optionBuilder.Options);
        }
    }
}
