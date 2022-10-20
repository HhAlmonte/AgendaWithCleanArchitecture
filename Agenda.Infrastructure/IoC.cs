using Agenda.Application.Interfaces;
using Agenda.Infrastructure.Context;
using Agenda.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Agenda.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPersonService, PersonService>();

            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IAgendaDbContext, AgendaDbContext>();

            services.AddDbContext<AgendaDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
