using Blog.Models;
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
            connection.Open();
            // InsertTag(connection);          
            connection.Close();
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