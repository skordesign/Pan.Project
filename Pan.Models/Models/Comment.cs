using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Comment:Base
    {
        public string Content { get; set; } = "";
        public long? TaskId { get; set; }
        public virtual PanTask Task { get; set; }
        public long? ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual Attach Attach { get; set; }
    }
}
