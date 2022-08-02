using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Form
    {
        public int IdForm { get; set; }
        public int? UserId { get; set; }
        public string? NameForm { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? NbrComposants { get; set; }

        public virtual User? User { get; set; }
    }
}
