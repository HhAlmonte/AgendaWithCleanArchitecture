using Agenda.Application.Generic.Dtos;

namespace Agenda.Application.Person.Dtos
{
    public class PersonDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? NickName { get; set; }
    }
}
