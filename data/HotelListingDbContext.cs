using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data{
    public class HotelListingDbContext : DbContext {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseMySql(
    //         @"server=localhost:3305;database=HotelListingDb;uid=root;password=sifre;",
    //         new MySqlServerVersion(new Version(8, 0, 11))
    //         );
    // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country{
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country{
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel{
                    Id = 1,
                    Name = "Sandals & Yacht",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel{
                    Id = 2,
                    Name = "Mercenaries",
                    Address = "Bahama St.",
                    CountryId = 2,
                    Rating = 4
                }
            );

        }
    }
}