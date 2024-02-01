using Practice.Model.Entities.Abstract;

namespace Practice.Model.Entities.Concrets;

public class S_Card:Base
{
 

    public int Id_Student { get; set; }

    public virtual Student Student { get; set; }

    public int Id_Book  { get; set; }

    public virtual Book Book { get; set; }

    public DateTime DateOut{ get; set; }

    public DateTime DateIn{ get; set; }

    public int Id_Lib { get; set; }
    public virtual Lib Lib { get; set; }



}
