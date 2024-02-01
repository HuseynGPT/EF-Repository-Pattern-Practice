using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Faculty:BaseEntity
{
    public virtual ICollection<Group> Groups { get; set; }
}
