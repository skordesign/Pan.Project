using System.Collections.Generic;
using System.Threading.Tasks;
using Pan.Models.Models;

namespace Pan.Services.DAOs
{
    public class TaskService : ITaskService
    {
        public Task<IEnumerable<Attach>> GetAttachs(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> GetCategory(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<PanTask> GetParentTask(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Project> GetProjectOfTask(long taskId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<PanTask>> GetSubTaskOfTask(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
