using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class PanTask:Base
    {
        public string Name { get; set; } = "";
        public DateTime Estimate { get; set; } = DateTime.UtcNow;
        public string Tags { get; set; } = "";
        public long? ParentTaskId { get; set; }
        public virtual PanTask ParentTask { get; set; }
        public long? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public long ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Attach> Attachs { get; set; }
        public virtual ICollection<PanTask> SubTasks { get; set; }
        public virtual ICollection<TaskMember> TaskMembers { get; set; }
    }
}
