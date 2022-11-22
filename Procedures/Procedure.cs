using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Procedures
{
    // public class Procedure<TRep> where TRep : class
    // {
    //     private readonly SqlConnection _connection;
    //     public Procedure(SqlConnection connection)
    //         => _connection = connection;
    //    public static void Read(SqlConnection connection)
    //     {
    //         var repository = new Repository<TRep>(connection);
    //         var items = repository.Get();

    //         foreach (var item in items)
    //             Console.WriteLine($"ID: {item.Id} - Nome: {item.Name}");
    //     }

    //     public static void Update(SqlConnection connection, int id)
    //     {
    //         var repository = new Repository<TRep>(connection);
    //         var user = new User()
    //         {
    //             Id=id,
    //             Name ="",
    //             Email ="",
    //             PasswordHash="",
    //             Bio="",
    //             Image="",
    //             Slug=""
    //         };
    //         repository.Update(user);
    //     }

    //     public static void Delete(SqlConnection connection,int Id)
    //     {
    //         var repository = new Repository<TRep>(connection);
    //         repository.Delete(Id);
    //     }
    // }
}