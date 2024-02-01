using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasOne(x => x.Group)
             .WithMany(x => x.Students)
             .HasForeignKey(x=>x.Id_Group);
    }
}
