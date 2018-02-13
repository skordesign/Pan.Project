using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Project:Base
    {
        public bool IsPublic { get; set; } = true;
        public string Name { get; set; } = "";
        public DateTime Deadline { get; set; } = DateTime.UtcNow.AddHours(4);
        public long? ProjectTypeId { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public long? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<ProjectTeam> ProjectTeams { get; set; }
        public virtual ICollection<Attach> Attachs { get; set; }
        public virtual ICollection<PanTask> Tasks { get; set; }
    }
}
