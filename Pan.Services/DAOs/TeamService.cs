using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pan.Models.Models;

namespace Pan.Services.DAOs
{
    public class TeamService : ITeamService
    {
        public Task<IEnumerable<Member>> GetMembersOfTeam(long teamId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsOfTeam(long teamId)
        {
            throw new NotImplementedException();
        }
    }
}
