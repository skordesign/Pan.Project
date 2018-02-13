using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class ProjectTeam
    {
        public long TeamId { get; set; }
        public virtual Team Team { get; set; }
        public long ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
