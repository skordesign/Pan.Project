using Pan.Models.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface ITaskService
    {
        Task<Project> GetProjectOfTask(long taskId);
        Task<IEnumerable<PanTask>> GetSubTaskOfTask(long id);
        Task<PanTask> GetParentTask(long id);
        Task<Category> GetCategory(long id);
        Task<IEnumerable<Attach>> GetAttachs(long id);
    }
}
