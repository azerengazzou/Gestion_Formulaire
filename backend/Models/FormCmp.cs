using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class FormCmp
    {
        public int IdForm { get; set; }
        public int IdCmp { get; set; }
        public string NomForm { get; set; }

        public virtual Cmp IdCmpNavigation { get; set; }
        public virtual Form IdFormNavigation { get; set; }
    }
}
