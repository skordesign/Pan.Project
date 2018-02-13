using Microsoft.Extensions.DependencyInjection;
using Pan.Services.DAOs;
using System;

namespace Pan.Services
{
    public static class PanServices
    {
        public static void AddPanServices(this IServiceCollection services,
          ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            services.AddTransient<IProjectTypeService, ProjectTypeService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IMemberService, MemberService>();
        }
    }
}
