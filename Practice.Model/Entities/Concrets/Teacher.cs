using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Teacher:BaseEntityForPersons
{

    public int Id_Department{ get; set; }
    public virtual Department Department { get; set; }

    public virtual  ICollection<T_Card> t_Cards { get; set; }
}
