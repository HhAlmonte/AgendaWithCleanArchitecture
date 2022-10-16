using Agenda.Application.Generic.Handlers;
using Agenda.Application.Generic.Interfaces;
using Agenda.Application.Person.Dtos;
using AutoMapper;

namespace Agenda.Application.Person.Handlers
{
    public interface IPersonHandler : IBaseCrudHandler<PersonDto, Domain.Entities.Person>
    {
        new Task<PersonDto> GetById(int id);
        new Task<PersonDto> Update(PersonDto dto);
        new Task<PersonDto> Update(int id, PersonDto dto);
        new Task<PersonDto> Create(PersonDto dto);
    }

    public class PersonHandler : BaseCrudHandler<PersonDto, Domain.Entities.Person>, IPersonHandler
    {
        public PersonHandler(IBaseCrudService<Domain.Entities.Person> crudService, IMapper mapper) : base(crudService, mapper)
        {
        }

        public new async Task<PersonDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<PersonDto> Update(PersonDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<PersonDto> Update(int id, PersonDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<PersonDto> Create(PersonDto dto)
        {
            return await base.Create(dto);
        }
    }
}
