using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pan.Models.Models;
using Skor.EFCoreExtensions.Repositories;

namespace Pan.Services.DAOs
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly IBaseRepository<Project> project;
        public ProjectTypeService(IBaseRepository<Project> p)
        {
            project = p;
        }
        public async Task<IEnumerable<Project>> GetProjectsOfType(long projectTypeId)
        {
            return await project.GetAllAsync(o => o.ProjectTypeId == projectTypeId);
        }
    }
}
