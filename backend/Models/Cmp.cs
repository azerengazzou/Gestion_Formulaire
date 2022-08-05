using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class Cmp
    {
        public Cmp()
        {
            CmpDetails = new HashSet<CmpDetail>();
            FormCmps = new HashSet<FormCmp>();
        }

        public int IdCmp { get; set; }
        public string CmpBtn { get; set; }
        public string CmpCalendrier { get; set; }
        public string CmpInput { get; set; }
        public string CmpRadioCheck { get; set; }
        public string CmpSelectopt { get; set; }

        public virtual ICollection<CmpDetail> CmpDetails { get; set; }
        public virtual ICollection<FormCmp> FormCmps { get; set; }
    }
}
