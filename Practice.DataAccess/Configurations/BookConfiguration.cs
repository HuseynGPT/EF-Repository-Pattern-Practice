using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice.Model.Entities.Concrets;
using System.Reflection.Emit;

namespace Practice.DataAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);
        builder
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.Id_Author);

        builder.HasOne(b => b.Category)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.Id_Category);

        builder.HasOne(b => b.Theme)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.Id_Theme);

        builder.HasOne(b => b.Press)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.Id_Press);
    }
}
