using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Student:BaseEntityForPersons
{

    public int Id_Group { get; set; }
    public virtual Group Group { get; set; }
    public virtual ICollection<S_Card> S_Cards{ get; set; }

}
