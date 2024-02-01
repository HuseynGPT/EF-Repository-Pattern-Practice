using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Category:BaseEntity
{

    public virtual ICollection<Book> Books{ get; set; }
}
