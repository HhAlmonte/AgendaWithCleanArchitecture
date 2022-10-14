namespace Agenda.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
