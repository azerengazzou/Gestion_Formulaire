using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class User
    {
        public User()
        {
            Forms = new HashSet<Form>();
        }

        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Form> Forms { get; set; }
    }
}
