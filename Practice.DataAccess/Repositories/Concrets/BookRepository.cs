using Microsoft.EntityFrameworkCore;
using Practice.DataAccess.Repositories.Abstracts;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Concrets;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public ICollection<Book>  ReturnBooksByAuthorId(int IdAuthor)
    {
        return _context.Books.Where(x=> x.Id_Author == IdAuthor).ToList();
    }

    public ICollection<Book> ReturnBooksByCategoryId(int IdCategory)
    {
        return _context.Books.Where(x => x.Id_Category == IdCategory).ToList();
    }
}
