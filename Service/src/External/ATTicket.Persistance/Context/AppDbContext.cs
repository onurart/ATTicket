using ATTicket.Domain.Abstractions;
using ATTicket.Domain.AppEntities;
using ATTicket.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ATTicket.Persistance.Context
{
    public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(){}
        public AppDbContext(DbContextOptions options) : base(options){}
        public DbSet<Company> Companies { get; set; }
        public DbSet<MainRole> MainRoles { get; set; }
        public DbSet<AppUserRole> UserRoles { get; set; }
        public DbSet<UserAndCompanyRelationship> UserAndCompanyRelationships { get; set; }
        public DbSet<MainRoleAndUserRelationship> MainRoleAndUserRelationships { get; set; }
        public DbSet<Error> Error { get; set; }
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<IdentityUserLogin<string>>();
            builder.Ignore<IdentityUserRole<string>>();
            builder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            builder.Ignore<IdentityRoleClaim<string>>();

            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    FirstName = "Onur",
                    LastName = "Umutluoglu",
                    RefreshToken = Guid.NewGuid().ToString(),
                    UserName = "onur",
                    NormalizedUserName = "ONUR",
                    Email = "onurumutluoglu@gmail.com",
                    NormalizedEmail = "ONURUMUTLUOGLU@GMAIL.COM",
                    Id = "45d7be85-af9e-4241-8933-e7e5a5020849",
                    NameLastName = "Onur Umutluoglu",
                    PasswordHash = "AQAAAAIAAYagAAAAEDEtGUt+pTdcsr7fWnH/wZ8lCAdhyveRfEU5RAjsvrDjQENcGESkOqAwyVx7RqrTbw==",
                    SecurityStamp = "UGM43S2UTDAM4GLLRJERICUKWLE7MEYD",
                }
                );
            builder.Entity<MainRole>().HasData(
                new MainRole { Id = "02188350-e299-442d-8620-d17bbf855fdb", Title = "ADMIN", IsRoleCreatedByAdmin = false, CreatedDate = DateTime.Now },
                new MainRole { Id = "5e9915cc-bc27-4e26-8684-0a0e38a7c801", Title = "EDITOR", IsRoleCreatedByAdmin = false, CreatedDate = DateTime.Now },
                new MainRole { Id = "f42c9b68-7ea3-4812-8697-1c8667e29e31", Title = "USER", IsRoleCreatedByAdmin = false, CreatedDate = DateTime.Now }
            );
            builder.Entity<MainRoleAndUserRelationship>().HasData(
                new MainRoleAndUserRelationship
                {
                    Id = "990d8fe5-6805-4805-bfcb-a4f4a5e18871",
                    UserId = "45d7be85-af9e-4241-8933-e7e5a5020849",
                    MainRoleId = "02188350-e299-442d-8620-d17bbf855fdb",
                    CreatedDate = DateTime.Now
                }
                );
            //builder.Entity<MainRoleAndUserRelationship>()
            //   .HasOne(e => e.MainRoleId).WithMany(e=>e.)
            //.OnDelete(DeleteBehavior.ClientCascade);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("SqlServer"));
        }
    }

}
