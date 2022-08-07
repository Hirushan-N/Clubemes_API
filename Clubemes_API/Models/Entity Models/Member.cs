namespace Clubemes_API.Models
{
    public class Member:BaseEntity
    {
        public int? Id { get; set; }
        public string? MembershipCode { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Addres { get; set; }
        public string? TP { get; set; }
    }
}
