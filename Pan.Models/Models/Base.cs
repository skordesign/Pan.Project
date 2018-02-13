using System;

namespace Pan.Models.Models
{
    public class Base
    {
        public long Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedTime { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; } = "";
        public string IP { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
