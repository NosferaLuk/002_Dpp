using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class TagPersist : Repository<Tag>
    {
        public readonly SqlConnection _Connection;
        public TagPersist(SqlConnection connection) : base(connection)
            =>_Connection = connection;
    }
}