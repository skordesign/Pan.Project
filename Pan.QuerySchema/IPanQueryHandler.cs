using Pan.QuerySchema.HandleObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.QuerySchema
{
    public interface IPanQueryHandler
    {
        Task<object> Handle(RequestObject requestObject);
    }
}
