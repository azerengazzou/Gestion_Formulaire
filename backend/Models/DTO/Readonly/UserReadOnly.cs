namespace backend.Models.DTO.Readonly
{
    public class UserReadOnly
    {
        public int id { get; set; }
        public String? fullname { get; set; }
        public String? email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public String FormName { get; set; }
    }
}
