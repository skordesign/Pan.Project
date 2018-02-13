using GraphQL.Types;
using Pan.Models.Models;

namespace Pan.QuerySchema.GraphObjects
{
    public class BaseObject<T> : ObjectGraphType<T> where T : Base
    {
        public BaseObject()
        {
            Field(f => f.CreatedTime);
            Field(f => f.Description);
            Field(f => f.Id);
            Field(f => f.IP);
            Field(f => f.UpdatedBy);
            Field(f => f.UpdatedTime);
            Field(f => f.Status);
        }
    }
}
