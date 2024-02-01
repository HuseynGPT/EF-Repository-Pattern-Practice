using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Department:BaseEntity
{
    public virtual ICollection<Teacher> Teachers{ get; set; }
}
