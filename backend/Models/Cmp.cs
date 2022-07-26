﻿using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Cmp
    {
        public Cmp()
        {
            IdDetails = new HashSet<Detail>();
            IdForms = new HashSet<Form>();
        }

        public int IdCmp { get; set; }
        public string CmpBtn { get; set; }
        public string CmpCalendrier { get; set; }
        public string CmpInput { get; set; }
        public string CmpRadioCheck { get; set; }
        public string CmpSelectopt { get; set; }

        public virtual ICollection<Detail> IdDetails { get; set; }
        public virtual ICollection<Form> IdForms { get; set; }
    }
}
