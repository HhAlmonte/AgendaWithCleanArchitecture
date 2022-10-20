using Agenda.Application.Interfaces;
using Agenda.Domain.Entities;
using Agenda.Infrastructure.Context;
using AutoMapper;

namespace Agenda.Infrastructure.Services
{
    public class UserService : BaseCrudService<User>, IUserService
    {
        public UserService(IAgendaDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
