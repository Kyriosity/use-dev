using Microsoft.EntityFrameworkCore;
using PrimusBackend.Entities;

namespace PrimusBackend.Storage;
public class MeasDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Temperature> Temperatures { get; set; }
}
