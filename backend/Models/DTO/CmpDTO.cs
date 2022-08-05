namespace backend.Models.DTO
{
    public class CmpDTO
    {
        public int IdCmp { get; set; }
        public string CmpBtn { get; set; }
        public string CmpCalendrier { get; set; }
        public string CmpInput { get; set; }
        public string CmpRadioCheck { get; set; }
        public string CmpSelectopt { get; set; }

        public virtual ICollection<CmpDetailmMV> CmpDetails { get; set; }
        public virtual ICollection<FormCmpmMV> FormCmps { get; set; }
    }
    public class FormCmpmMV
    {
        public int IdForm { get; set; }
    }
        
}
