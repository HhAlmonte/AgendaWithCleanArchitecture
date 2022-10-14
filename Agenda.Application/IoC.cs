using Agenda.Application.User.Handlers;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Agenda.Application
{
    public static class IoC
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddTransient<IUserHandler, UserHandler>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
