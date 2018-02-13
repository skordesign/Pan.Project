using GraphQL.Types;
using Pan.Models.Models;
using Pan.Services.DAOs;
using System;

namespace Pan.QuerySchema.GraphObjects
{
    public class ProjectObject : BaseObject<Project>
    {
        private readonly IProjectService project;
        public ProjectObject(IProjectService p)
        {
            project = p;
            Field(f => f.Deadline);
            Field(f => f.Name);
            Field(f => f.IsPublic);
            FieldAsync<ProjectTypeObject>("projectType",
                resolve: async context => await project.GetProjectType(context.Source.Id));
            FieldAsync<ListGraphType<MemberObject>>("members",
                resolve: async context => await project.GetMembersOfProject(context.Source.Id));
            FieldAsync<ListGraphType<TeamObject>>("teams",
                resolve: async context => await project.GetTeamsOfProject(context.Source.Id));
        }
    }
}
