using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Api.Data
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Coutry { get; set; }



    }
}
