using DatingAppAPI.Entities;

namespace DatingAppAPI.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(string Id);
        Task<AppUser> GetUserByUsernameAsync(string username);
    }
}
