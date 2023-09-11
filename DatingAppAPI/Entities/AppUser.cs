using System.ComponentModel.DataAnnotations;

namespace DatingAppAPI.Entities
{
    public class AppUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
