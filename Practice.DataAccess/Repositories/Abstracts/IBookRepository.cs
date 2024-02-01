using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface IBookRepository:IBaseRepository<Book>
{
    ICollection<Book> ReturnBooksByAuthorId (int IdAuthor);
    ICollection<Book> ReturnBooksByCategoryId (int IdCategory);


}
