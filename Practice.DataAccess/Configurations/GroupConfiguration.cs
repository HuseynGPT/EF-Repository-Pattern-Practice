using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);
    }
}
