using Agenda.Application.Person.Handlers;
using Agenda.Application.User.Handlers;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Agenda.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IUserHandler, UserHandler>();
            
            services.AddTransient<IPersonHandler, PersonHandler>();
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            
            return services;
        }
    }
}
