using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Category:Base
    {
        public string Name { get; set; }
        public virtual ICollection<PanTask> PanTasks { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
