using Microsoft.EntityFrameworkCore;
using SmartRequests.Models;

namespace SmartRequests.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<SmartRequest> Requests => Set<SmartRequest>();
}
