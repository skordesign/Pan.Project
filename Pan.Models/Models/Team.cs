using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Team:Base
    {
        public string Name { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<ProjectTeam> ProjectTeams { get; set; }
    }
}
