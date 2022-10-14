namespace Agenda.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? NickName { get; set; }
    }
}
