using System.ComponentModel.DataAnnotations;

namespace backend.Models.DTO.Update
{
    public class UserUpdate
    {
        [Required]
        public String Fullname { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }
    }
}
