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

    }
}
