using Microsoft.EntityFrameworkCore;
using todoApi.Models;

namespace todoApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
}