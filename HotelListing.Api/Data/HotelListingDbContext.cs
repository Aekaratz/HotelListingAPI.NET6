using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(

                new Country
                {
                    Id = 1,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Banana",
                     ShortName = "BN"
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "Jamaica",
                      ShortName = "JM"
                  }
                );

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    HotelId = 1,
                    Name = "Tara Resort",
                    Address = "Kanchanaburi",
                    CountryId = 1,
                    Rating = 3.5

                },
                 new Hotel
                 {
                     HotelId = 2,
                     Name = "Mala Resort",
                     Address = "BKK",
                     CountryId = 2,
                     Rating = 4.5

                 },
                  new Hotel
                  {
                      HotelId = 3,
                      Name = "Baiyok",
                      Address = "BKK",
                      CountryId = 3,
                      Rating = 5

                  }
                );
        }
    }
}
