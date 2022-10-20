using Agenda.Application.Interfaces;
using Agenda.Domain.Entities;
using Agenda.Infrastructure.Context;
using AutoMapper;

namespace Agenda.Infrastructure.Services
{
    public class PersonService : BaseCrudService<Person>, IPersonService
    {
        public PersonService(IAgendaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
