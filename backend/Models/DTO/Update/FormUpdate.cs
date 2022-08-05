namespace backend.Models.DTO.Update
{
    public class FormUpdate
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string NameForm { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? NbrComposants { get; set; }
    }
}
