using HotelListing.Api.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.Api.Contracts
{

    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthResponeDto>Login(LoginDto loginDto);

        Task<string> CreateRefreshToken();

        Task<AuthResponeDto>VerifyRefreshToken(AuthResponeDto request);
    }
}
