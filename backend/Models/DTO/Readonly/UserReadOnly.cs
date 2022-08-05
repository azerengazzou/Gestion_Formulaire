namespace backend.Models.DTO.Readonly
{
    public class UserReadOnly
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<FormDTO>? Forms { get; set; }
    }
    public class FormmMV {
        public int IdForm { get; set; }
        public int? UserId { get; set; }
        public string NameForm { get; set; }
        public string Description { get; set; }
    }
       
}
