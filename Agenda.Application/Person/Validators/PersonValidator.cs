using Agenda.Application.Person.Dtos;
using FluentValidation;

namespace Agenda.Application.Person.Validators
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithName("Invalid-Email")
                .WithMessage("Email inválido");

            RuleFor(x => x.PhoneNumber)
                .Matches(@"^\d{3}-\d{3}-\d{4}$")
                .Length(10)
                .WithName("Invalid-PhoneNumber")
                .WithMessage("Telefone inválido");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(3, 50)
                .WithName("Invalid-Name")
                .WithMessage("Nombre inválido");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(3, 50)
                .WithName("Invalid-LastName")
                .WithMessage("Apellido inválido");
        }
    }
}
