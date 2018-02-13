using GraphQL.Types;
using Pan.Models.Models;
using Pan.Services.DAOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pan.QuerySchema.GraphObjects
{
    public class TeamObject:BaseObject<Team>
    {
        private readonly ITeamService team;
        public TeamObject(ITeamService t)
        {
            team = t;
            Field(f => f.Name);
            FieldAsync<ListGraphType<MemberObject>>("members",
                resolve: async context => await team.GetMembersOfTeam(context.Source.Id));
            FieldAsync<ListGraphType<MemberObject>>("projects", 
                resolve: async context =>await team.GetProjectsOfTeam(context.Source.Id));
        }
    }
}
