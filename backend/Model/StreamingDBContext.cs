using Microsoft.EntityFrameworkCore;

namespace Backend.Model;

public class StreamingDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Content> Contents { get; set; }
}