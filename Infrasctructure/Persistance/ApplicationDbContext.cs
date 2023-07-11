using System.Reflection;
using Domain.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrasctructure.Persistance;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }
    private readonly DbContextOptions<ApplicationDbContext> _options;
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IConfiguration configuration
    ) : base(options)
    {
        _options = options;
        _configuration = configuration;
    }

    public DbSet<Employee> Employees { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseNpgsql(connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        base.OnModelCreating(builder);
    }
}