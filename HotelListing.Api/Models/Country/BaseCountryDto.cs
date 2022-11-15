﻿using Microsoft.Build.Framework;

namespace HotelListing.Api.Models.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }
    }
}
