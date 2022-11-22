using System;
using Blog.Models;
using Blog.Procedures;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Blog
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trust Server Certificate = true";
        public static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            
            var procedure = new Procedure();

            connection.Open();
            // procedure.ReadUsers(connect);
            InsertTag(connection);
            // ReadUsers(connection);            
            // ReadRoles(connection);            
            // ReadTags(connection);            
            connection.Close();
        }
        
        public static void UpdateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Id=1,
                Name ="",
                Email ="",
                PasswordHash="",
                Bio="",
                Image="",
                Slug=""
            };
            repository.Update(user);
        }

        public static void DeleteUser(SqlConnection connection,int Id)
        {
            var repository = new Repository<User>(connection);
            repository.Delete(Id);
        }
        public static void InsertTag(SqlConnection connection)
        {
            var tag = new Tag()
            {
                Name = "ASP.NET",
                Slug = "aspnet"
            };
            connection.Insert(tag);   
        }
    }
}