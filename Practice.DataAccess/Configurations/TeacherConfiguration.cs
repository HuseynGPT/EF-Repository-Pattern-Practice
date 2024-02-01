using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Configurations;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasOne(x => x.Department)
             .WithMany(x => x.Teachers)
             .HasForeignKey(x => x.Id_Department);
    }
}
