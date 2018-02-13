using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.Models.Models
{
    public class Attach:Base
    {
        public string FileLocation { get; set; } = "";
        public string FileLocationBackup { get; set; } = "";
        public long? PanTaskId { get; set; }
        public virtual PanTask Task { get; set; }
        public long? CommentId { get; set; }
        public virtual Comment Comment { get; set; }
        public long? ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
