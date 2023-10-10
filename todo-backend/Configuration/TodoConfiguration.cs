using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using todo_backend.Models;

namespace todo_backend.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("todos"); // Name table in SQL Server
            builder.HasKey(t => t.Id); // Primary key
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.IsComplete).IsRequired().HasDefaultValue(false); // setup default value "FALSE" 
        }
    }
}
