using Pan.Models.Models;

namespace Pan.QuerySchema.GraphObjects
{
    public class CategoryObject:BaseObject<Category>
    {
        public CategoryObject()
        {
            Field(f => f.Name);
        }
    }
}
