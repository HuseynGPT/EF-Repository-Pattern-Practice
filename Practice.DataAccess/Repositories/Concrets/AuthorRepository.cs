using Microsoft.EntityFrameworkCore;
using Practice.DataAccess.Repositories.Abstracts;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Concrets;

public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
{
    public ICollection<Author> GetAllWithBook()
    {
        return _context.Authors.Include(a => a.Books).ToList();
    }
}
