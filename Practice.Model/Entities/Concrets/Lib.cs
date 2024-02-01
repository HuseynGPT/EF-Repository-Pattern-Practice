using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class Lib:BaseEntityForPersons
{
    public virtual ICollection<T_Card> T_Cards{ get; set; }
    public virtual ICollection<S_Card> S_Cards{ get; set; }
}
