using GraphQL.Types;
using Pan.QuerySchema.GraphObjects;
using Pan.Services.DAOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.QuerySchema
{
    public class PanQuery: ObjectGraphType, IPanQuery
    {
        private readonly IProjectService project;
        public PanQuery(IProjectService p)
        {
            project = p;
            FieldAsync<ListGraphType<ProjectObject>>("projects",
                resolve: async context =>
                {
                    return await project.GetAllProjects();
                });
        }
    }
}
