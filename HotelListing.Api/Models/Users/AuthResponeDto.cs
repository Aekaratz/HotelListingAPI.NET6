namespace HotelListing.Api.Models.Users
{
    public class AuthResponeDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
