using DatingAppAPI.Data.Repositories.Interfaces;
using DatingAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Data.Repositories.Impementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DatingAppContext _context;

        public UserRepository(DatingAppContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetUserByIdAsync(string Id)
        {
            return await _context.Users
                .Include(p => p.Photos)
                .FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<AppUser> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .Include(p => p.Photos)
                .FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .Include(p => p.Photos)
                .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(AppUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
