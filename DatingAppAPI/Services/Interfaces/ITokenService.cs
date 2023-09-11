using DatingAppAPI.Entities;

namespace DatingAppAPI.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
