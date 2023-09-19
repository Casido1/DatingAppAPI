using DatingAppAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingAppAPI.Data
{
    public class DatingAppContext : DbContext
    {
        public DatingAppContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
            .Property(x => x.DateOfBirth)
            .HasConversion<DateOnlyConverter>()
            .HasColumnType("date");

            base.OnModelCreating(modelBuilder);
        }

        public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
        {
            public DateOnlyConverter() : base(dateonly => dateonly.ToDateTime(TimeOnly.MinValue), dateTime => DateOnly.FromDateTime(dateTime))
            {

            }
        }
    }
}
