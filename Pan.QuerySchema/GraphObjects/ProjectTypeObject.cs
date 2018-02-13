using GraphQL.Types;
using Pan.Models.Models;
using Pan.Services.DAOs;

namespace Pan.QuerySchema.GraphObjects
{
    public class ProjectTypeObject:BaseObject<ProjectType>
    {
        private readonly IProjectTypeService projectType;
        public ProjectTypeObject(IProjectTypeService pT)
        {
            projectType = pT;
            Field(f => f.Name);
            FieldAsync<ListGraphType<ProjectObject>>("projects",
                resolve: async context => await projectType.GetProjectsOfType(context.Source.Id));
        }
    }
}
