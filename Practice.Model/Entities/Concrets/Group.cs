using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Group: BaseEntity
{
    public int Id_Faculty { get; set; }
    public virtual Faculty Faculty { get; set; }

    public virtual ICollection<Student> Students { get; set; }
}
