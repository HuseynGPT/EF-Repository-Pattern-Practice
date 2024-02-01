using Microsoft.EntityFrameworkCore;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Repositories.Abstracts;

public interface ILibRepository : IEntityTypeConfiguration<Lib>
{
}
