using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface ICategoryRepository:IBaseRepository<Category>
{
    Category GetCategoryByName(string CategoryName);

}
