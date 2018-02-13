using GraphQL.Types;
using Pan.Models.Models;
using Pan.Services.DAOs;

namespace Pan.QuerySchema.GraphObjects
{
    public class TaskObject:BaseObject<PanTask>
    {
        private readonly ITaskService task;
        public TaskObject(ITaskService t)
        {
            task = t;
            Field(f => f.Estimate);
            Field(f => f.Name);
            Field(f => f.Status);
            Field(f => f.Tags);
            FieldAsync<ProjectObject>("project", resolve: async context => await task.GetProjectOfTask(context.Source.Id));
            FieldAsync<ListGraphType<TaskObject>>("subTasks", resolve: async _ => await task.GetSubTaskOfTask(_.Source.Id));
            FieldAsync<TaskObject>("parentTask", resolve: async _ => await task.GetParentTask(_.Source.Id));
            FieldAsync<CategoryObject>("category",resolve: async _ => await task.GetCategory(_.Source.Id));
            FieldAsync<ListGraphType<AttachObject>>("attachs", resolve: async _ => await task.GetAttachs(_.Source.Id));
        }
    }
}
