using Microsoft.EntityFrameworkCore;

namespace Backend.Model;

public class StreamingDBContext : DbContext
{
    public StreamingDBContext(DbContextOptions options)
        : base(options) {}
    
    public StreamingDBContext() { }

    public DbSet<Content> Contents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("my-memory-db");
    }
}