using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.QuerySchema.HandleObjects
{
    public class RequestObject
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
        public string Method { get; set; }
    }
}
