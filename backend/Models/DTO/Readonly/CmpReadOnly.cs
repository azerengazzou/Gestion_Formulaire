namespace backend.Models.DTO.Readonly
{
    public class CmpReadOnly
    {
        public int IdCmp { get; set; }
        public string CmpBtn { get; set; }
        public string CmpCalendrier { get; set; }
        public string CmpInput { get; set; }
        public string CmpRadioCheck { get; set; }
        public string CmpSelectopt { get; set; }
        public virtual IList<FormmMV> Form { get; set; }
    }
}
