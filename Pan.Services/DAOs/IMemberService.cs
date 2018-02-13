using Pan.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface IMemberService
    {
        Task<IEnumerable<Project>> GetProjectsOfMember(long memberId);
        Task<IEnumerable<Team>> GetTeamsOfMember(long memberId);
    }
}
