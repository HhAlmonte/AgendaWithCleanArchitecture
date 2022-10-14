using Agenda.Application.User.Dtos;
using FluentValidation;

namespace Agenda.Application.User.Validators
{
    public class UserValidators : AbstractValidator<UserDto>
    {
        public UserValidators()
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

            RuleFor(x => x.UserName)
                .NotEmpty()
                .Length(3, 50)
                .WithName("Invalid-UserName")
                .WithMessage("Nombre de Usuario inválido");
        }
    }
}
