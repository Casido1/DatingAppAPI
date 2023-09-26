using DatingAppAPI.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppAPI.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepo;

        public UsersController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepo.GetUsersAsync();

            return Ok(users);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            var user = await _userRepo.GetUserByUsernameAsync(username);

            return Ok(user);
        }
    }
}
