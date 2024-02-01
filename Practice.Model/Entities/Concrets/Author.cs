using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Author:BaseEntityForPersons
{

    public virtual ICollection<Book> Books { get; set; }
}
