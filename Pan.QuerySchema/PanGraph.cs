using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Pan.QuerySchema.GraphObjects;
using Pan.Services;
using Pan.Services.DAOs;
using System;

namespace Pan.QuerySchema
{
    public static class PanGraph
    {
        public static void AddPanGraph(this IServiceCollection services)
        {
            services.AddPanServices();
            services.AddTransient<ProjectObject>();
            services.AddTransient<ProjectTypeObject>();
            services.AddTransient<IPanQueryHandler, PanQueryHandler>();
            services.AddTransient<IPanQuery, PanQuery>();
            services.AddTransient<IDocumentExecuter, DocumentExecuter>();
            services.AddTransient<ISchema>(
              s => new PanSchema(new FuncDependencyResolver(type => (GraphType)s.GetService(type))));
        }
    }
}
