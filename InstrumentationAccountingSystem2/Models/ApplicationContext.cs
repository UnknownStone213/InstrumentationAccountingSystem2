using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstrumentationAccountingSystem2.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public override DbSet<User> Users { get; set; }
        public DbSet<Instrumentation> Instrumentations { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Verification> Verifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>()
                .HasMany(i => i.Instrumentations)
                .WithOne(i => i.Location)
                .HasForeignKey(i => i.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);
            modelBuilder.Entity<Type>()
                .HasMany(i => i.Instrumentations)
                .WithOne(i => i.Type)
                .HasForeignKey(i => i.TypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);
        }
    }
}
