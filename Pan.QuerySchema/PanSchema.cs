using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.QuerySchema
{
    public class PanSchema : Schema
    {
        public PanSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<IPanQuery>();
        }
    }
}
