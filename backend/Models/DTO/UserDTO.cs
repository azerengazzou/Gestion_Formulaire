using System.ComponentModel.DataAnnotations;

namespace backend.Models.DTO
{
    public class UserDTO
    {

        [Required]
        public String Fullname { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
