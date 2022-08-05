namespace backend.Models.DTO.Readonly
{
    public class DetailsReadOnly
    {

        public int Id { get; set; }
        public string LabelText { get; set; }
        public string Name { get; set; }
        public string PlaceHolder { get; set; }
        public string TypeInput { get; set; }
        public string Size { get; set; }
        public string Value { get; set; }
        public string MinCalendrier { get; set; }
        public string MaxCalendrier { get; set; }
        public string TypeBtn { get; set; }
        public string TypeCmp { get; set; }

        public virtual IList<CmpDetailmMV> CmpDetails { get; set; }
    }
   
}
