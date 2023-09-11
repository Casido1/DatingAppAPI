using DatingAppAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DatingAppContext _context;

        public UsersController(DatingAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUserById(string Id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);

            return Ok(user);
        }
    }
}
