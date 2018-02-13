using GraphQL.Types;
using Pan.Models.Models;
using Pan.Services.DAOs;

namespace Pan.QuerySchema.GraphObjects
{
    public class MemberObject:BaseObject<Member>
    {
        private readonly IMemberService member;
        public MemberObject(IMemberService m)
        {
            member = m;
            Field(f => f.Guid);
            Field(f => f.Email);
            Field(f => f.Firstname);
            Field(f => f.Lastname);
            Field(f => f.Facebook);
            Field(f => f.GooglePlus);
            Field(f => f.Skype);
            Field(f => f.Twitter);
            Field(f => f.Blog);
            Field(f => f.Pinterest);
            Field(f => f.Slack);
            Field(f => f.Github);
            Field(f => f.Hackerank);
            Field(f => f.Docker);
            FieldAsync<ListGraphType<ProjectObject>>("projects", 
                resolve: async (context) => await member.GetProjectsOfMember(context.Source.Id));
            FieldAsync<ListGraphType<TeamObject>>("teams", 
                resolve: async context => await member.GetTeamsOfMember(context.Source.Id));
        }
    }
}
