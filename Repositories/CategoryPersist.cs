using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class CategoryPersist: Repository<Category>
    {
        public readonly SqlConnection _Connection;
        public CategoryPersist(SqlConnection connection) : base(connection)
            =>_Connection = connection;
    }
}