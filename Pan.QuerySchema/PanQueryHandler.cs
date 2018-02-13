using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Pan.QuerySchema.HandleObjects;

namespace Pan.QuerySchema
{
    public class PanQueryHandler : IPanQueryHandler
    {
        private readonly ISchema schema;
        private readonly IDocumentExecuter documentExecuter;
        public PanQueryHandler(ISchema s, IDocumentExecuter d)
        {
            schema = s;
            documentExecuter = d;
        }
        public async Task<object> Handle(RequestObject requestObject)
        {
            var result = await documentExecuter.ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = requestObject.Query;
                _.OperationName = requestObject.OperationName;
                _.Inputs = requestObject.Variables.ToInputs();
            }).ConfigureAwait(false);
            return result;
        }
    }
}
