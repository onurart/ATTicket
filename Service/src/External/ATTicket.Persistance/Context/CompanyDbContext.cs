using ATTicket.Domain.Abstractions;
using ATTicket.Domain.AppEntities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Context;
public sealed class CompanyDbContext : DbContext
{
    private string ConnectionString = "";
    public CompanyDbContext(Company company = null)
    {
        if (company != null)
        {
            if (String.IsNullOrEmpty(company.ServerUserId))
                ConnectionString = $"" +
                    $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DatabaseName};" +
                    //$"Integrated Security=True;" +
                    $"Connect Timeout=3000;" +
                    $"Encrypt=False;" +
                    $"TrustServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False;" +
                    $"Command Timeout=0";
            else
                ConnectionString = $"" +
                    $"Data Source={company.ServerName};" +
                    $"Initial Catalog={company.DatabaseName};" +
                    $"User Id={company.ServerUserId};" +
                    $"Password={company.ServerPassword};" +
                    //$"Integrated Security=True;" +
                    $"Connect Timeout=3000;" +
                    $"Encrypt=False;" +
                    $"TrustServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False;" +
                    $"Command Timeout=0";
        }

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionString = "Data Source=.;Initial Catalog=ATBasketRobotsMehmetDb;User Id=at;Password=AT123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

    public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
    {
     public CompanyDbContext CreateDbContext(string[] args)
        {
            return new CompanyDbContext();
        }
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<Entity>();
        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Property(p => p.CreatedDate)
                    .CurrentValue = DateTime.Now;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Property(p => p.UpdatedDate)
                    .CurrentValue = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}