using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Form
    {
        public Form()
        {
            FormCmps = new HashSet<FormCmp>();
        }

        public int IdForm { get; set; }
        public int? UserId { get; set; }
        public string NameForm { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? NbrComposants { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<FormCmp> FormCmps { get; set; }
    }
}
