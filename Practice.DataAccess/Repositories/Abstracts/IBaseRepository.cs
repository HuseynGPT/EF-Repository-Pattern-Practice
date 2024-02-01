using Practice.Model.Entities.Abstract;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface IBaseRepository<T> where T : Base, new()
{
    ICollection<T> GetAll();
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    void Save();
}
