using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(

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
