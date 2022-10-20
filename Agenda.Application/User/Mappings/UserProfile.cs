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
            
            CreateMap<UserPasswordDto, Domain.Entities.User>()
                .ForPath(dest => dest.Person.Email, op =>
                op.MapFrom(source => source.Email))
                .ForPath(dest => dest.Person.FullName, op =>
                op.MapFrom(source => $"{source.FirstName} {source.LastName}"))
                .ReverseMap();

            CreateMap<UserDto, Domain.Entities.Person>();
            
            CreateMap<Domain.Entities.Person, UserDto>();
        }
    }
}
