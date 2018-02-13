using Pan.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProject(long id);
        Task<ProjectType> GetProjectType(long projectId);
        Task<IEnumerable<Member>> GetMembersOfProject(long projectId);
        Task<IEnumerable<Team>> GetTeamsOfProject(long projectId);
    }
}
