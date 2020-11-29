using Microsoft.EntityFrameworkCore;

namespace todo_api_net.Models
{
  public class DataContext : DbContext
  {
    public DbSet<Task> Task { get; set; } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=todo.db");
    }
  }
}