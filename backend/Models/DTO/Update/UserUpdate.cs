using System.ComponentModel.DataAnnotations;

namespace backend.Models.DTO.Update
{
    public class UserUpdate
    {
        public int Id { get; set; }
        [Required]
        public String Fullname { get; set; }

        
        public String Email { get; set; }

        
        public String Password { get; set; }
    }
}
