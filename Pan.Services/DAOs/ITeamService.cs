using Pan.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface ITeamService
    {
        Task<IEnumerable<Member>> GetMembersOfTeam(long teamId);
        Task<IEnumerable<Project>> GetProjectsOfTeam(long teamId);
    }
}
