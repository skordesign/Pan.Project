using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Pan.Models.Models;
using Skor.EFCoreExtensions.DI;

namespace Pan.Database
{
    public static class PanDatabase
    {
        public static void AddPanDatabase(this IServiceCollection services, string connectionString,
           ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            services.AddEntityFrameworkSqlServer().AddDbContext<PanDbContext>(options => {
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Pan.Database"));
            }, serviceLifetime);
            services.AddTransientRepository<Project, PanDbContext>();
            services.AddTransientRepository<Member, PanDbContext>();
            services.AddTransientRepository<ProjectType, PanDbContext>();
            services.AddTransientRepository<ProjectMember, PanDbContext>();
            services.AddTransientRepository<Position, PanDbContext>();
            services.AddTransientRepository<ProjectTeam, PanDbContext>();
            services.AddTransientRepository<Team, PanDbContext>();
            services.AddTransientRepository<TeamMember, PanDbContext>();
            services.AddTransientRepository<PanTask, PanDbContext>();
            services.AddTransientRepository<Comment, PanDbContext>();
            services.AddTransientRepository<Attach, PanDbContext>();
            services.AddTransientRepository<TaskMember, PanDbContext>();
        }
    }
}
