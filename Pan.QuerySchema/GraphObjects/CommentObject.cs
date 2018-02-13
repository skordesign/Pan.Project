using Pan.Models.Models;
using Pan.Services.DAOs;

namespace Pan.QuerySchema.GraphObjects
{
    public class CommentObject:BaseObject<Comment>
    {
        private readonly ICommentService comment;
        public CommentObject(ICommentService c)
        {
            comment = c;
            Field(f => f.Content);
            FieldAsync<AttachObject>("attachs", resolve: async _ => await comment.GetAttachs(_.Source.Id) );
            FieldAsync<ProjectObject>("project", resolve: async _ => await comment.GetProject(_.Source.Id));
            FieldAsync<TaskObject>("task", resolve: async _ => await comment.GetTask(_.Source.Id));
        }
    }
}
