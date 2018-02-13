using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pan.Models.Models;
using Skor.EFCoreExtensions.Repositories;

namespace Pan.Services.DAOs
{
    public class ProjectService : IProjectService
    {
        private readonly IBaseRepository<ProjectType> projectType;
        private readonly IBaseRepository<ProjectMember> projectMember;
        private readonly IBaseRepository<ProjectTeam> projectTeam;
        private readonly IBaseRepository<Team> team;
        private readonly IBaseRepository<Member> member;
        private readonly IBaseRepository<Project> project;
        public ProjectService(IBaseRepository<ProjectType> pType,
            IBaseRepository<ProjectMember> pM,
            IBaseRepository<ProjectTeam> pT,
            IBaseRepository<Team> t,
            IBaseRepository<Project> p,
            IBaseRepository<Member> m)
        {

            projectType = pType; projectMember = pM; projectTeam = pT; team = t; member = m; project = p;
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            return await project.GetAllAsync();
        }

        public async Task<IEnumerable<Member>> GetMembersOfProject(long projectId)
        {
            var p = await project.GetAsync(projectId);
            List<ProjectMember> listMember = (await projectMember.GetAllAsync(o => o.ProjectId == p.Id)).ToList();
            return await member.GetAllAsync(o => listMember.Any(m => m.MemberId == o.Id));
        }

        public async Task<Project> GetProject(long id)
        {
            return await project.GetAsync(id);
        }

        public async Task<ProjectType> GetProjectType(long projectId)
        {
            var p = await project.GetAsync(projectId);
            var pT = await projectType.GetAsync((long)p.ProjectTypeId);
            return pT;
        }

        public async Task<IEnumerable<Team>> GetTeamsOfProject(long projectId)
        {
            var p = await project.GetAsync(projectId);
            List<ProjectTeam> listTeam = (await projectTeam.GetAllAsync(o => o.ProjectId == p.Id)).ToList();
            return await team.GetAllAsync(o => listTeam.Any(m => m.TeamId == o.Id));
        }
    }
}
