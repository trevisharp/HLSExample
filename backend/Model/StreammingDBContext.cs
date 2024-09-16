using Microsoft.EntityFrameworkCore;

namespace Backend.Model;

public class StreammingDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Content> Contents { get; set; }
}