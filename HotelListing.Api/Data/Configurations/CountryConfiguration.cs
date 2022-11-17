﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Api.Data.Configurations
{
    public class CountryConfiguration:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {

            builder.HasData(

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
        }
    }
}
