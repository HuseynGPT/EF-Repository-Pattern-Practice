using Practice.DataAccess.Repositories.Concrets;

using Practice.Model.Entities.Concrets;

 S_CardRepository contextt = new();
//S_CardRepository context = new();
//GenericRepository<Author,int> context = new();
BaseRepository<Category> context = new();
for (int i = 1; i < 10; i++)
{
    context.Add(new Category()
    {
        Name = "Auhtor " + i,

    });
}
context.Save();

var datas = context.GetAll();
foreach (var data in datas)
{

    //Console.WriteLine(data.Student.Name);
    //Console.WriteLine(data.Book.Name);

    Console.WriteLine(data.Name);
    //Console.WriteLine(data.Surname);
}