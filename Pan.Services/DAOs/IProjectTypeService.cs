using Pan.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface IProjectTypeService
    {
        Task<IEnumerable<Project>> GetProjectsOfType(long projectTypeId);
    }
}
