using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DatingAppAPI.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Url { get; set; }

        public bool IsMain { get; set; }

        public string PublicId { get; set; }

        [Required]
        public string AppUserId { get; set; }

        [JsonIgnore]
        public AppUser AppUser { get; set; }

    }
}