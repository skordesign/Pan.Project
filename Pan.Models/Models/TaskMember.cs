using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class TaskMember
    {
        public long MemberId { get; set; }
        public virtual Member Member { get; set; }
        public long TaskId { get; set; }
        public virtual PanTask Task { get; set; }
    }
}
