using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class RolePersist: Repository<Role>
    {
        public readonly SqlConnection _Connection;
        public RolePersist(SqlConnection connection) : base(connection)
            =>_Connection = connection;
    }
}