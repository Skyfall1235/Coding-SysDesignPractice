using Microsoft.EntityFrameworkCore;

namespace rideshare_practice.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<RideDatum> rideData => Set<RideDatum>();
        public DbSet<RideInstance> RideInstances => Set<RideInstance>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Driver>()
                .HasOne(d => d.User)
                .WithOne()
                .IsRequired()
                .HasForeignKey<Driver>(d => d.UserId);

            builder.Entity<RideDatum>()
                .HasOne(d => d.Driver)
                .WithOne()
                .IsRequired()
                .HasForeignKey<Driver>(d => d.UserId);

            builder.Entity<RideInstance>()
                .HasOne(ri => ri.Datum)
                .WithOne()
                .IsRequired()
                .HasForeignKey<RideInstance>(ri => ri.Datum);

            builder.Entity<RideInstance>()
                .HasOne()


        }
    }
}
