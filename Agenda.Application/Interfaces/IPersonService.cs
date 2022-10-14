using Agenda.Application.Generic.Interfaces;
using Agenda.Domain.Entities;

namespace Agenda.Application.Interfaces
{
    public interface IPersonService : IBaseCrudService<Person>
    {
    }
}
