using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface IS_CardRepository:IBaseRepository<S_Card>
{
    ICollection<Book> GetBooksBetweenDates(DateTime startDate, DateTime endDate);
    ICollection<Book> GetBooksTakenByStudentFromId(int StudentId);

}
