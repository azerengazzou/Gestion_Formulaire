namespace backend.Models.DTO.Readonly
{
    public class FormReadOnly
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string NameForm { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? NbrComposants { get; set; }
        public virtual UserDTO User { get; set; }
        public IList<CmpDTO> Cmplist { get; set; }
        
    }
    public class UsermMV
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
    }
    public class CmpmMV
    {
        public int IdCmp { get; set; }
    }
}
