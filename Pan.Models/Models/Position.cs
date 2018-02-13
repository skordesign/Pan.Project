using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Position:Base
    {
        public string Name { get; set; } = "";
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
    }
}
