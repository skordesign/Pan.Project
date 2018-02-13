using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pan.QuerySchema;
using Pan.QuerySchema.HandleObjects;

namespace Pan.API.Controllers
{
    [Route("api/[controller]")]
    public class QueryController : Controller
    {
        private readonly IPanQueryHandler handler;
        public QueryController(IPanQueryHandler h)
        {
            handler = h;
        }

        // GET api/values/5
        [HttpPost]
        public async Task<JsonResult> Query([FromBody]RequestObject requestObject)
        {
            var result = await handler.Handle(requestObject);
            return new JsonResult(result);
        }
        
    }
}
