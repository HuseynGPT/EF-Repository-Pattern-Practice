using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Configurations;

public class S_CardConfiguration : IEntityTypeConfiguration<S_Card>
{
    public void Configure(EntityTypeBuilder<S_Card> builder)
    {
        builder.HasOne(x => x.Student)
            .WithMany(s => s.S_Cards)
            .HasForeignKey(x => x.Id_Student);

        builder.HasOne(x => x.Book)
            .WithMany(b => b.S_Cards)
            .HasForeignKey(x => x.Id_Book);

        builder.HasOne(b=> b.Lib)
            .WithMany(x=>x.S_Cards)
            .HasForeignKey(x=>x.Id_Lib);
    }
}
