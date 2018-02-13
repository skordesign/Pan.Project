using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class TeamMember
    {
        public long MemberId { get; set; }
        public virtual Member Member { get; set; }
        public long TeamId { get; set; }
        public virtual Team Team { get; set; }
        public long? PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
