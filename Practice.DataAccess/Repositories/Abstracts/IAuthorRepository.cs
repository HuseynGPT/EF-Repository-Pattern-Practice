using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface IAuthorRepository:IBaseRepository<Author>
{
    ICollection<Author> GetAllWithBook();
}
