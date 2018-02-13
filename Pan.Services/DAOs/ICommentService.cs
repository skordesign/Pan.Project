using Pan.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pan.Services.DAOs
{
    public interface ICommentService
    {
        Task<Attach> GetAttachs(long id);
        Task<PanTask> GetTask(long id);
        Task<Project> GetProject(long id);
    }
}
