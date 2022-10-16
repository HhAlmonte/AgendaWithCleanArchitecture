using Agenda.Application.User.Dtos;
using Agenda.Domain.Entities;
using AutoMapper;

namespace Agenda.Application.User.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, Domain.Entities.User>().ReverseMap();
            
            CreateMap<UserPasswordDto, Domain.Entities.User>().ReverseMap();
            
            CreateMap<UserDto, Domain.Entities.Person>().ForMember(dest => dest.FullName,
                op => op.MapFrom(source => $"{source.FirstName} {source.LastName}"));

            CreateMap<Domain.Entities.Person, UserDto>();
        }
    }
}
