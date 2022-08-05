using System;
using System.Collections.Generic;

namespace backend.Models
{
    public partial class CmpDetail
    {
        public int IdCmp { get; set; }
        public int IdDetails { get; set; }
        public DateTime? DateCreation { get; set; }

        public virtual Cmp IdCmpNavigation { get; set; }
        public virtual Detail IdDetailsNavigation { get; set; }
    }
}
