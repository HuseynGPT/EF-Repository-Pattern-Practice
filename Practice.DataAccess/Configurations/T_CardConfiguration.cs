using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Configurations;

public class T_CardConfiguration : IEntityTypeConfiguration<T_Card>
{
    public void Configure(EntityTypeBuilder<T_Card> builder)
    {
        builder.HasOne(x => x.Teacher)
     .WithMany(s => s.t_Cards)
     .HasForeignKey(x => x.Id_Teacher);

        builder.HasOne(x => x.Book)
            .WithMany(b => b.T_Cards)
            .HasForeignKey(x => x.Id_Book);

        builder.HasOne(b => b.Lib)
            .WithMany(x => x.T_Cards)
            .HasForeignKey(x => x.Id_Lib);
    }
}
