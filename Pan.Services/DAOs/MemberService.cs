using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pan.Models.Models;

namespace Pan.Services.DAOs
{
    public class MemberService : IMemberService
    {
        public Task<IEnumerable<Project>> GetProjectsOfMember(long memberId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Team>> GetTeamsOfMember(long memberId)
        {
            throw new NotImplementedException();
        }
    }
}
