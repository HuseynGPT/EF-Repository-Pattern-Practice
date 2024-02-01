using Practice.DataAccess.Repositories.Abstracts;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Concrets;

internal class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public Category GetCategoryByName(string CategoryName)
    {
        return _context.Categories.First(x => x.Name == CategoryName);
    }
}
