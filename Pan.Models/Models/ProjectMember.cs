using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class ProjectMember
    {
        public long ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public long MemberId { get; set; }
        public virtual Member Member { get; set; }
        public long? PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
