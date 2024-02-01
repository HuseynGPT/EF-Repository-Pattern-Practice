using Microsoft.EntityFrameworkCore;
using Practice.Model.Entities.Concrets;

namespace Practice.DataAccess.Contexts;

public class PracticeDatabaseContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies()
            .UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Practice_Database;Integrated Security=True;Trust Server Certificate=True;");


        // Data Source=MSI\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<S_Card> S_Cards { get; set; }
    public virtual DbSet<Student> Students { get; set; }

}
