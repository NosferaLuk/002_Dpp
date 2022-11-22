using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories 
{
    public class UserPersist : Repository<User>
    {
        public readonly SqlConnection _Connection;
        public UserPersist(SqlConnection connection) : base(connection)
        {
            _Connection = connection;
        }

    }
}