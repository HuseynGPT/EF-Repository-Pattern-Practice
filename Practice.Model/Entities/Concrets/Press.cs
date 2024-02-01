using Practice.Model.Entities.Abstract;
using System.Reflection.Metadata.Ecma335;

namespace Practice.Model.Entities.Concrets;

public class Press : BaseEntity
{
    public virtual ICollection<Book> Books { get; set; }
}
