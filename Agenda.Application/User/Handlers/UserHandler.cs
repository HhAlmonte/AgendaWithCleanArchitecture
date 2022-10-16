using Agenda.Application.Generic.Handlers;
using Agenda.Application.Generic.Interfaces;
using Agenda.Application.Interfaces;
using Agenda.Application.User.Dtos;
using AutoMapper;

namespace Agenda.Application.User.Handlers
{
    public interface IUserHandler : IBaseCrudHandler<UserPasswordDto, Domain.Entities.User>
    {
        new Task<UserDto> GetById(int id);
        new Task<UserDto> Update(UserPasswordDto dto);
        new Task<UserDto> Update(int id, UserPasswordDto dto);
        new Task<UserDto> Create(UserPasswordDto dto);
    }

    public class UserHandler : BaseCrudHandler<UserPasswordDto, Domain.Entities.User>, IUserHandler
    {   
        public UserHandler(IUserService userService, IMapper mapper) : base(userService, mapper)
        {
        }

        public new async Task<UserDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<UserDto> Update(UserPasswordDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<UserDto> Update(int id, UserPasswordDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<UserDto> Create(UserPasswordDto dto)
        {
            return await base.Create(dto);
        }
    }
}
