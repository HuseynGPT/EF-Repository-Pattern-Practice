
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface IStudentRepository:IBaseRepository<Student>
{
    Student GetStudentByName(string Name);

}
