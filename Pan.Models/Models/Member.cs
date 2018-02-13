using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Member:Base
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = "";
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Facebook { get; set; } = "";
        public string GooglePlus { get; set; } = "";
        public string Skype { get; set; } = "";
        public string Twitter { get; set; } = "";
        public string Blog { get; set; } = "";
        public string Pinterest { get; set; } = "";
        public string Slack { get; set; } = "";
        public string Github { get; set; } = "";
        public string Hackerank { get; set; } = "";
        public string Docker { get; set; } = "";
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<TaskMember> TaskMembers { get; set; }
    }
}
